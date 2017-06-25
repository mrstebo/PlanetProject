using System.Linq;
using Moq;
using NUnit.Framework;
using PlanetProject.Core.Models;
using PlanetProject.Core.Services;
using PlanetProject.Data.Entities;
using PlanetProject.Data.Repositories;

namespace PlanetProject.Core.Tests.Services
{
    [TestFixture]
    [Parallelizable]
    public class PlanetServiceTests
    {
        [SetUp]
        public void SetUp()
        {
            _planetRepository = new Mock<IPlanetRepository>();
            _service = new PlanetService(_planetRepository.Object);
        }

        private Mock<IPlanetRepository> _planetRepository;
        private IPlanetService _service;

        [Test]
        public void GetAll_ShouldReturn_Planets()
        {
            _planetRepository
                .Setup(x => x.All())
                .Returns(Enumerable.Range(1, 3).Select(i => new PlanetEntity {Id = i, Name = $"Planet {i}"}));

            var results = (_service.GetAll() ?? Enumerable.Empty<Planet>()).ToArray();

            Assert.AreEqual(3, results.Length);
            Assert.AreEqual("Planet 1", results[0].Name);
            Assert.AreEqual("Planet 2", results[1].Name);
            Assert.AreEqual("Planet 3", results[2].Name);
        }

        [Test]
        public void GetByName_ShouldReturn_Planet()
        {
            _planetRepository
                .Setup(x => x.GetByName("earth"))
                .Returns(new PlanetEntity {Id = 1, Name = "Earth"});

            var result = _service.GetByName("earth");

            Assert.IsNotNull(result);
            Assert.AreEqual("Earth", result.Name);
        }

        [Test]
        public void GetByName_When_PlanetDoesNotExist_ShouldReturn_Null()
        {
            _planetRepository
                .Setup(x => x.GetByName("pluto"))
                .Returns(() => null);

            var result = _service.GetByName("pluto");

            Assert.IsNull(result);
        }
    }
}

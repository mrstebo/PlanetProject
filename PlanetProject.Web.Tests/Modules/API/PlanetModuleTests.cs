using System.Collections.Generic;
using System.Linq;
using Moq;
using Nancy;
using Nancy.Testing;
using NUnit.Framework;
using PlanetProject.Core.Models;
using PlanetProject.Core.Services;
using PlanetProject.Web.Modules.API;
using PlanetProject.Web.ViewModels;

namespace PlanetProject.Web.Tests.Modules.API
{
    [TestFixture]
    [Parallelizable]
    public class PlanetModuleTests
    {
        [SetUp]
        public void SetUp()
        {
            _planetService = new Mock<IPlanetService>();
            _browser = new Browser(with =>
            {
                with.Module<PlanetModule>();
                with.Dependency(_planetService.Object);
            });
        }

        private Mock<IPlanetService> _planetService;
        private Browser _browser;

        [Test]
        public void Get_ShouldReturn_CollectionOf_PlanetViewModel()
        {
            _planetService
                .Setup(x => x.GetAll())
                .Returns(Enumerable.Range(1, 3).Select(i => new Planet {Name = $"Planet {i}"}));

            var response = _browser.Get("/api/planets", with => with.HttpRequest());

            var result = response.Body.DeserializeJson<List<PlanetViewModel>>();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Planet 1", result[0].Name);
            Assert.AreEqual("Planet 2", result[1].Name);
            Assert.AreEqual("Planet 3", result[2].Name);
        }

        [Test]
        public void Get_WithName_ShouldReturn_PlanetViewModel()
        {
            _planetService
                .Setup(x => x.GetByName("earth"))
                .Returns(new Planet {Name = "Earth"});

            var response = _browser.Get("/api/planets/earth", with => with.HttpRequest());

            var result = response.Body.DeserializeJson<PlanetViewModel>();

            Assert.IsNotNull(result);
            Assert.AreEqual("Earth", result.Name);
        }

        [Test]
        public void Get_WithName_When_PlanetDoesNotExist_ShouldReturn_NotFound()
        {
            _planetService
                .Setup(x => x.GetByName("pluto"))
                .Returns(() => null);

            var response = _browser.Get("/api/planets/pluto", with => with.HttpRequest());

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using HtmlAgilityPack;
using PlanetProject.Data.Entities;

namespace PlanetProject.Data.Seeders
{
    internal class NasaPlanetSeeder : IPlanetSeeder
    {
        private readonly HttpClient _client = new HttpClient();

        public IEnumerable<PlanetEntity> Seed()
        {
            var doc = LoadDocument();   
            var planetNames = FindPlanetNames(doc).ToArray();

            return Enumerable.Empty<PlanetEntity>();
        }

        private HtmlDocument LoadDocument()
        {
            const string url = "https://nssdc.gsfc.nasa.gov/planetary/factsheet/";

            var html = _client.GetStringAsync(url).Result;
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            return doc;
        }

        private static IEnumerable<string> FindPlanetNames(HtmlDocument doc)
        {
            return doc.DocumentNode
                .SelectNodes("//a[contains(@href, 'fact.html')]")
                .Select(x => x.InnerText.ToLowerInvariant());
        }
    }
}

using Nancy;
using PlanetProject.Web.ViewModels;

namespace PlanetProject.Web.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["Home"];
        }
    }
}
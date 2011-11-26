using System.Collections.Generic;
using System.Web.Mvc;
using MvcTreeView.Models;

namespace MvcTreeView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var locations = new List<Location>
                                {
                                    new Location
                                        {
                                            Id = 1,
                                            Name = "United States",
                                            ChildLocations =
                                                {
                                                    new Location {Id = 2, Name = "Chicago", ChildLocations =
                                                                                                {
                                                                                                    new Location { Name = "Rack 1"},
                                                                                                    new Location { Name = "Rack 2"},
                                                                                                    new Location { Name = "Rack 3"},
                                                                                                }},
                                                    new Location {Id = 2, Name = "Dallas"}
                                                }
                                        },
                                         new Location
                                        {
                                            Id = 1,
                                            Name = "Canada",
                                            ChildLocations =
                                                {
                                                    new Location {Id = 2, Name = "Ontario"},
                                                    new Location {Id = 2, Name = "Windsor"}
                                                }
                                        }
                                };
            return View(locations);
        }


    }
}

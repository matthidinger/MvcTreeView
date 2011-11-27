using System.Collections.Generic;
using System.Web.Mvc;
using $rootnamespace$.Models;

namespace $rootnamespace$.Controllers
{
    public class TreeViewController : Controller
    {
        public ActionResult Index()
        {
            var locations = new List<TreeViewLocation>
                                {
                                    new TreeViewLocation
                                        {
                                            Name = "United States",
                                            ChildLocations =
                                                {
                                                    new TreeViewLocation
                                                        {
                                                            Name = "Chicago",
                                                            ChildLocations =
                                                                {
                                                                    new TreeViewLocation {Name = "Rack 1"},
                                                                    new TreeViewLocation {Name = "Rack 2"},
                                                                    new TreeViewLocation {Name = "Rack 3"},
                                                                }
                                                        },
                                                    new TreeViewLocation {Name = "Dallas"}
                                                }
                                        },
                                    new TreeViewLocation
                                        {
                                            Name = "Canada",
                                            ChildLocations =
                                                {
                                                    new TreeViewLocation {Name = "Ontario"},
                                                    new TreeViewLocation {Name = "Windsor"}
                                                }
                                        }
                                };

            return View(locations);
        }
    }
}

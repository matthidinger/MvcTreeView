using System.Collections.Generic;

namespace MvcTreeView.Models
{
    public class Location
    {
        public Location()
        {
            ChildLocations = new HashSet<Location>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual int? ParentLocationId { get; set; }
        
        public virtual ICollection<Location> ChildLocations { get; set; }
    }
}
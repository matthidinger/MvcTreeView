using System.Collections.Generic;

namespace $rootnamespace$.Models
{
    public class TreeViewLocation
    {
        public TreeViewLocation()
        {
            ChildLocations = new HashSet<TreeViewLocation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual int? ParentLocationId { get; set; }
        
        public virtual ICollection<TreeViewLocation> ChildLocations { get; set; }
    }
}
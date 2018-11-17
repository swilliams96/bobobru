using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Layout
    {
        public int LayoutId { get; set; }
        public int RestaurantId { get; set; }
        public bool Active { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Image { get; set; }
        public int TableCount { get; set; }

        public ICollection<TableGroup> TableGroups { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }

        public ICollection<Layout> Layouts { get; set; }
    }
}

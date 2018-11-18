using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Table
    {
        public int TableId { get; set; }
        public int LayoutId { get; set; }
        public Layout Layout { get; set; }
        public Link TableGroup { get; set; }
        public string Name { get; set; }
        public ShapeType ShapeType { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Radius { get; set; }
        public int SeatCount { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Link> TableLinks { get; set; }
    }
}

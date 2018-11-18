using System;
using System.Collections.Generic;
using System.Text;
using Models.Entities;

namespace Models.ViewModels
{
    public class TableViewModel
    {
        public int TableId { get; set; }
        public int TableGroupId { get; set; }
        public string Name { get; set; }
        public ShapeType ShapeType { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Radius { get; set; }
        public int SeatCount { get; set; }
    }
}

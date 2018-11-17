using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Table
    {
        public int TableId { get; set; }
        public int TableGroupId { get; set; }
        public TableGroup TableGroup { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int SeatCount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class TableGroup
    {
        public int TableGroupId { get; set; }
        public int LayoutId { get; set; }
        public Layout Layout { get; set; }

        public ICollection<Table> Tables { get; set; }
    }
}

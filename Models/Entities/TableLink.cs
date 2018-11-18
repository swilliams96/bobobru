using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Link
    {
        public int LinkId { get; set; }
        public int TableOneId { get; set; }
        public Table TableOne { get; set; }
        public int TableTwoId { get; set; }
        public Table TableTwo { get; set; }
        public int SeatsLost { get; set; }        
    }
}

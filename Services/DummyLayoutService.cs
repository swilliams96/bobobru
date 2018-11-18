using System;
using System.Collections.Generic;
using System.Text;
using Models.Entities;
using Models.ViewModels;

namespace Services
{
    public class DummyLayoutService : ILayoutService
    {
        public IEnumerable<Table> GetTables(int layoutId)
        {
            return new List<Table>()
            {
                new Table()
                {
                    TableId = 1,
                    TableGroupId = 1,
                    Name = "Table1",
                    ShapeType = ShapeType.Rectangle,
                    X = 10,
                    Y = 10,
                    Width = 10,
                    Height = 10,
                    Radius = 0,
                    SeatCount = 4
                },
                new Table()
                {
                    TableId = 2,
                    TableGroupId = 1,
                    Name = "Table2",
                    ShapeType = ShapeType.Rectangle,
                    X = 20,
                    Y = 20,
                    Width = 10,
                    Height = 10,
                    Radius = 0,
                    SeatCount = 2
                },
                new Table()
                {
                    TableId = 3,
                    TableGroupId = 2,
                    Name = "Table1",
                    ShapeType = ShapeType.Circle,
                    X = 30,
                    Y = 30,
                    Width = 0,
                    Height = 0,
                    Radius = 5,
                    SeatCount = 6
                }
            };
        }

        public IEnumerable<Layout> GetLayouts(int restaurantId)
        {
            return new List<Layout>()
            {
                new Layout()
                {
                    RestaurantId = restaurantId,
                    LayoutId = 1,
                    Active = true,
                    TableCount = 4,
                    Image = "<svg viewBox=\"0 0 100 100\"><rect x\"10\" y=\"10\" width=\"60\" height=\"60\" stroke=\"black\" fill=\"transparent\" stroke-width=\"5\"/></svg>",
                    Name = "floor 1"
                },
                new Layout()
                {
                    RestaurantId = restaurantId,
                    LayoutId = 2,
                    Active = true,
                    TableCount = 4,
                    Image = "<svg viewBox=\"0 0 100 100\"><rect x\"10\" y=\"10\" width=\"70\" height=\"70\" stroke=\"green\" fill=\"transparent\" stroke-width=\"5\"/></svg>",
                    Name = "floor 2"
                }
            };
        }

        public Table GetTable(int tableId)
        {
            return new Table()
            {
                TableId = 1
            };

        }

        public string SaveLayout(Layout layout)
        {
            throw new NotImplementedException();
        }
    }
}

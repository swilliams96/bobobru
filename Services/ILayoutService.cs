using System;
using System.Collections.Generic;
using System.Text;
using Models.Entities;
using Models.ViewModels;

namespace Services
{
    public interface ILayoutService
    {
        string SaveLayout(Layout layout);

        Table GetTable(int tableId);

        IEnumerable<Layout> GetLayouts(int restaurantId);

        IEnumerable<Table> GetTables(int layoutId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Models.Entities;
using Models.ViewModels;

namespace Services
{
    public class LayoutService : ILayoutService
    {
        private readonly Context context;

        public LayoutService(Context context)
        {
            this.context = context;
        }

        public Table GetTable(int tableId)
        {
            return context.Tables.SingleOrDefault(t => t.TableId == tableId);
        }

        public IEnumerable<Table> GetTables(int layoutId)
        {
            return context.Tables.Where(t => t.LayoutId == layoutId);
        }

        public IEnumerable<Layout> GetLayouts(int restaurantId)
        {
            return context.Layouts
                .Where(l => l.RestaurantId == restaurantId);
        }

        public string SaveLayout(Layout layout)
        {
            throw new NotImplementedException();
        }
    }
}

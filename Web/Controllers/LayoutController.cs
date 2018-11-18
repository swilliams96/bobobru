using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.ViewModels;
using Services;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LayoutController : Controller
    {
        private readonly ILayoutService layoutService;

        public LayoutController(ILayoutService layoutService)
        {
            this.layoutService = layoutService;
        }

        [HttpGet("[action]/{id}")]
        public IEnumerable<Table> GetTables([FromRoute] int id)
        {
            return layoutService.GetTables(id);
        }

        [HttpGet("[action]/{id}")]
        public IEnumerable<Layout> GetLayouts([FromRoute] int restaurantId)
        {
            return layoutService.GetLayouts(restaurantId);
        }
    }
}

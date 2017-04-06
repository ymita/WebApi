using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ItemsController : ApiController
    {
        private IItemRepository _rep;

        public ItemsController() : this(new ItemRepository())
        {

        }

        public ItemsController(ItemRepository rep)
        {
            this._rep = rep;
        }

        public Item getItem(int id)
        {
            var items = _rep.GetAll();
            var item = items.Where(x => x.Id == id).FirstOrDefault();
            return item;
        }

        public IEnumerable<Item> getAllItems()
        {
            var items = _rep.GetAll();
            return items;
        }
    }
}

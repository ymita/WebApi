using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ItemRepository : IItemRepository
    {
        private IEnumerable<Item> items;
        public IEnumerable<Item> GetAll()
        {
            items = getAllItems();
            return items;
        }

        private IEnumerable<Item> getAllItems()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item { Id = 1, Name = "My Item 1", RegisteredOn = DateTime.Today.AddDays(-2), CategoryId = 1 });
            items.Add(new Item { Id = 2, Name = "My Item 2", RegisteredOn = DateTime.Today.AddDays(-3), CategoryId = 2 });
            return items;
        }
    }
}
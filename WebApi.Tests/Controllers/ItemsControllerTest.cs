using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.Tests.Controllers
{
    [TestClass]
    public class ItemsControllerTest
    {
        private ItemsController _ctrl;

        [TestInitialize]
        public void MyTestInitialize()
        {
            this._ctrl = new ItemsController(new ItemRepository());
        }

        [TestMethod]
        public void ItemTest()
        {
            Item singleTestItem = this._ctrl.getItem(1) as Item;
            Assert.AreEqual(1, singleTestItem.Id);
        }

        [TestMethod]
        public void ItemsTest()
        {
            var allTestItems = this._ctrl.getAllItems();
            Assert.IsNotNull(allTestItems);
        }
    }
}

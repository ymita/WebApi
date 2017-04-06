﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi;
using WebApi.Controllers;

namespace WebApi.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // 準備
            ValuesController controller = new ValuesController();

            // 実行
            IEnumerable<string> result = controller.Get();

            // アサート
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // 準備
            ValuesController controller = new ValuesController();

            // 実行
            string result = controller.Get(5);

            // アサート
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // 準備
            ValuesController controller = new ValuesController();

            // 実行
            controller.Post("value");

            // アサート
        }

        [TestMethod]
        public void Put()
        {
            // 準備
            ValuesController controller = new ValuesController();

            // 実行
            controller.Put(5, "value");

            // アサート
        }

        [TestMethod]
        public void Delete()
        {
            // 準備
            ValuesController controller = new ValuesController();

            // 実行
            controller.Delete(5);

            // アサート
        }
    }
}

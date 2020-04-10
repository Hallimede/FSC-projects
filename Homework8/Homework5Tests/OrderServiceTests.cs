using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace Homework6.Tests
{
    [TestClass()]
    public class OrderServiceTests { 
    

        [TestMethod()]
        public void ExportTest()
        {
            File.Delete("exporttest.xml");
            Order o1 = new Order(8888, new Client("Li"), DateTime.Now);
            OrderService orderService = new OrderService();
            orderService.orderList.Add(o1);
            orderService.Export("exporttest.xml");
            //判断是否存在
            Assert.IsTrue(File.Exists("exporttest.xml"));
            //判断内容是否是想要的
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("exporttest.xml", FileMode.Open))
            {
                CollectionAssert.AreEqual(orderService.orderList, (List<Order>)xmlSerializer.Deserialize(fs));  
            }
        }
       

        [TestMethod()]
        public void ImportTest()
        {
            OrderService orderService = new OrderService();
            Order o1 = new Order(8888, new Client("Li"), DateTime.Now);
            List<Order> list = new List<Order>();
            list.Add(o1);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("exporttest.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, list);
            }
            orderService.Import("exporttest.xml");
            CollectionAssert.AreEqual(list, orderService.orderList);
        }

        [TestMethod()]
        public void SelectOrderTest()
        {
            Order o1 = new Order(8888, new Client("Li"), DateTime.Now);
            OrderService orderService = new OrderService();
            orderService.AddOrder(o1);
            List<Order> list = new List<Order>();
            list.Add(o1);
            //Assert.IsTrue(orderService.SelectOrder('A', "8888").Contains(o1));
            CollectionAssert.AreEqual(list, orderService.orderList);
        }

        [TestMethod()]
        public void SelectOrderTest1()
        {
            Order o1 = new Order(8888, new Client("Li"), DateTime.Now);
            OrderService orderService = new OrderService();
            Merchandise mc = new Merchandise("mc", 10);
            o1.OrderItems.Add(new OrderItem(mc, 10));

            orderService.AddOrder(o1);
            List<Order> list = new List<Order>();
            list.Add(o1);
            CollectionAssert.AreEqual(list, orderService.orderList);
        }
        [TestMethod()]
        public void SelectOrderTest2()
        {
            Order o1 = new Order(8888, new Client("Li"), DateTime.Now);
            OrderService orderService = new OrderService();
            orderService.AddOrder(o1);
            //Assert.IsTrue(orderService.SelectOrder('C', "Li").Contains(o1));
            List<Order> list = new List<Order>();
            list.Add(o1);
            CollectionAssert.AreEqual(list, orderService.orderList);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            Order o1 = new Order(8888, new Client("Li"), DateTime.Now);
            OrderService orderService = new OrderService();
            orderService.DeleteOrder(o1);
            Assert.IsFalse(orderService.orderList.Contains(o1));
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Order o1= new Order(8888, new Client("Li"), DateTime.Now);
            OrderService orderService = new OrderService();
            orderService.AddOrder(o1);
            Merchandise mc = new Merchandise("mc", 10);
            o1.OrderItems.Add(new OrderItem(mc,10));
            Assert.IsTrue(orderService.orderList.Contains(o1));
        }
        [TestMethod()]
        public void AddOrderTest1()
        {
            Order o1 = new Order();
            OrderService orderService = new OrderService();
            orderService.AddOrder(o1); 
            Assert.IsTrue(orderService.orderList.Contains(o1));
        }
        [TestMethod()]
        public void ChangeOrderTest()
        {
            Order o1 = new Order(8888, new Client("Li"), DateTime.Now);
            Order o2 = new Order(8889, new Client("Pi"), DateTime.Now);
            OrderService orderService = new OrderService();
            orderService.AddOrder(o1);
            orderService.ChangeOrder(0, o2);
            Assert.AreEqual(o2, orderService.orderList[0]);
        }

        [TestMethod()]
        public void IsInOrderListTest()
        {
            Order o1 = new Order(8888, new Client("Li"), DateTime.Now);
            OrderService orderService = new OrderService();
            orderService.AddOrder(o1);
            Assert.IsFalse(orderService.IsInOrderList(8888)==-1);
        }

        [TestMethod()]
        public void IsInOrderListTest1()
        {
            Order o1 = new Order(8888, new Client("Li"), DateTime.Now);
            OrderService orderService = new OrderService();
            orderService.AddOrder(o1);
            Assert.IsTrue(orderService.IsInOrderList(8888) == 0);
        }
        /*[TestCleanup]
        public void TestCleanUp()
        {
            
        }*/
    }
}
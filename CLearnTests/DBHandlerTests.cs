using Microsoft.VisualStudio.TestTools.UnitTesting;
using CLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CLearn.Tests
{
    [TestClass()]
    public class DBHandlerTests
    {
        /// <summary>
        /// Тест метода получения соединения
        /// </summary>
        [TestMethod()]
        public void GetConnectionTest()
        {
            DBHandler handler = new DBHandler();
            Assert.IsNotNull(handler.GetConnection());
        }
        /// <summary>
        /// Тест метода закрытия соединения
        /// </summary>
        [TestMethod()]

        public void CloseConnectionTest()
        {
            DBHandler handler = new DBHandler();
            handler.closeConnection();
            Assert.IsTrue(handler.GetConnection().State == System.Data.ConnectionState.Closed);
        }
        /// <summary>
        /// Тест метода открытия соединения
        /// </summary>
        [TestMethod()]

        public void OpenConnectionTest()
        {
            DBHandler handler = new DBHandler();
            handler.openConnection();
            Assert.IsTrue(handler.GetConnection().State == System.Data.ConnectionState.Open);
        }
        /// <summary>
        /// Тест правильного порта
        /// </summary>
        [TestMethod()]

        public void PortTest()
        {
            DBHandler dBHandler = new DBHandler();
            Assert.AreEqual(dBHandler.getPort(), "3306");
        }
        /// <summary>
        /// Тест Правильного пользовательского логина подключения
        /// </summary>
        [TestMethod()]

        public void UserTest()
        {
            DBHandler dBHandler = new DBHandler();
            Assert.AreEqual(dBHandler.getUser(), "root");
        }
        /// <summary>
        /// Тест правильного подключения к серверу
        /// </summary>
        [TestMethod()]
        public void ServerTest()
        {
            DBHandler dBHandler = new DBHandler();
            Assert.AreEqual(dBHandler.getServer(), "localhost");
        }
    }
}
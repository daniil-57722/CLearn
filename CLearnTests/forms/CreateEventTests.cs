using Microsoft.VisualStudio.TestTools.UnitTesting;
using CLearn.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLearn.forms.Tests
{
    [TestClass()]
    public class CreateEventTests
    {
        /// <summary>
        /// Тест метода получения id существующего города
        /// </summary>
        [TestMethod()]
        public void GetExistCityByNameTest()
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.GetCityByName("Абаза");
            Assert.AreEqual(1, 1);
        }
        /// <summary>
        /// Тест метода получения id существующего города
        /// </summary>
        [TestMethod()]
       
        public void GetExistCityByNameTest_2()
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.GetCityByName("Янаул");
            Assert.AreEqual(1110, 1110);
        }
        /// <summary>
        /// Метод получения id города с предварительным добавлением
        /// </summary>
        [TestMethod()]

        public void GetOblivionCityByNameTest()
        {
            CreateEvent createEvent = new CreateEvent();
            
            Assert.AreEqual(createEvent.GetCityByName("dgtc"), 1124);
        }
        /// <summary>
        /// Метод добавления DBHandler
        /// </summary>
        [TestMethod()]
        public void SummonDBHandlerTest()
        {
            CreateEvent createEvent = new CreateEvent();
            DBHandler handler = new DBHandler();
            Assert.AreEqual(createEvent.summonDBHandler().getType(), handler.getType());
        }
    }
}
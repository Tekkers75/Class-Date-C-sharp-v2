using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppDate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDate.Tests
{
    [TestClass()]
    public class DateTests
    {
        [TestMethod()]
        public void DateTest1() /// Тест конструктора
        {
            Date D2 = new Date(4, 7, 4);
            Assert.AreEqual(4, D2.GetDay());
            Assert.AreEqual(7, D2.GetMonth());
            Assert.AreEqual(4, D2.GetYear());
            //
        }

        [TestMethod()]
        public void SetDayTest()
        {
            Date D1 = new Date();
            D1.SetDay(13);
            Assert.AreEqual(13, D1.GetDay());

        }

        [TestMethod()]
        public void SetMonthTest()
        {
            Date D1 = new Date();
            D1.SetMonth(10);
            Assert.AreEqual(10, D1.GetMonth());
        }

        [TestMethod()]
        public void SetYearTest()
        {
            Date D1 = new Date();
            D1.SetYear(263);
            Assert.AreEqual(263, D1.GetYear());

        }

        [TestMethod()]
        public void ConvertDateTest() /// Тест перевода даты в дни
        {
            Date D1 = new Date(5, 7, 0);
            D1.ConvertDate();
            Assert.AreEqual(217, D1.ConvertDate());

        }

        [TestMethod()]
        public void SetDateInDayTest() /// Тест перевода дней в даты
        {
            Date D1 = new Date();
            D1.SetDateInDay(400);
            Assert.AreEqual(4, D1.GetDay());
            Assert.AreEqual(1, D1.GetMonth());
            Assert.AreEqual(1, D1.GetYear());
        }

        [TestMethod()]
        public void AllTest()  /// Общий тест
        {
            Date D1 = new Date();
            D1.SetDateInDay(600);
            D1.ConvertDate();
            D1.SubDay(10);
            D1.SubMonth(1);
            D1.SubYear(1);
            D1.AddDay(6);
            D1.AddMonth(4);
            D1.AddYear(5);
            Assert.AreEqual(D1.ToString(), Convert.ToString(19) + " days  " + Convert.ToString(10) + " month  " + Convert.ToString(5) + " year  ");
        }

    }
}
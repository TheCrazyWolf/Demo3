using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyCoreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCoreLib.Tests
{
    [TestClass()]
    public class AnalyticsTests
    {
        [TestMethod()]
        public void PopularMonthsTest()
        {

            var data = new List<DateTime>
            {
                DateTime.Parse("12.12.2020") ,
                DateTime.Parse("13.12.2020") ,
                DateTime.Parse("13.12.2020") ,
                DateTime.Parse("11.12.2020")
            };



            var expected = new List<DateTime>
            {
                DateTime.Parse("12.01.2022") ,
                DateTime.Parse("13.01.2022") ,
                DateTime.Parse("14.01.2022") ,
            };

            var actul = new Analytics().PopularMonths(data);

            Assert.ReferenceEquals(expected , actul);
        }

        [TestMethod()]
        public void PopularMonthsTest1()
        {

            var data = new List<DateTime>
            {
                DateTime.Parse("14.12.2020") ,
                DateTime.Parse("15.12.2020") ,
                DateTime.Parse("16.12.2020") ,
                DateTime.Parse("17.12.2020")
            };



            var expected = new List<DateTime>
            {
                DateTime.Parse("14.01.2022") ,
                DateTime.Parse("15.01.2022") ,
                DateTime.Parse("16.01.2022") ,
            };

            var actul = new Analytics().PopularMonths(data);

            Assert.ReferenceEquals(expected, actul);
        }



    }
}
using NUnit.Framework;

namespace Calculator_Test_1
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void CheckDateTimeTest()
        {
            //Calculator add = new Calculator();
            //int result = add.Add(15, 65);
            //Assert.That(result, Is.EqualTo(80));

            Calculator cal = new Calculator();
            bool kq = cal.CheckNgay(30, 4, 2021);
            Assert.That(kq, Is.EqualTo(true));
        }

        [Test]
        //[TestCase(15, 35, 50)]
        //[TestCase(10, 45, 55)]
        //[TestCase(20, 30, 60)]
        [TestCase(29, 2, 2016, true)]
        [TestCase(29, 2, 2017, true)]
        [TestCase(31, 5, 2022, true)]
        [TestCase(29, 2, 2020, true)]
        [TestCase(30, 2, 2001, true)]
        [TestCase(5, 8, 2001, true)]
        [TestCase(2021,5,5, true)]
        [TestCase(32,13,2021, false)]


        public void CheckDateTimeTest(int day, int month, int year, bool flag)
        {
            Calculator cal = new Calculator();
            bool kq = cal.CheckNgay(day, month, year);
            Assert.That(kq, Is.EqualTo(flag));
        }
    }
}
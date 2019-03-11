using NUnit.Framework;
using WarsawDengerousData.Helpers;

namespace WarsawDangerousData.Tests
{
    [TestFixture]
    public class DateTimeHelperTests
    {
        [Test]
        public void Given_CorrectSampleTestingDateInUnixFormat_Then_ReturnsStringDataAsExpected()
        {
            //arrange
            var testingDate = 12321312;

            //act
            var result = DateTimeHelper.GetUtcTime(testingDate);

            //assert
            Assert.AreEqual("1/1/1970 3:25:21 AM", result);
        }

        [Test]
        public void Given_ZeroValueCorrectSampleTestingDateInUnixFormat_Then_ReturnsStringDataAsExpected()
        {
            //arrange
            var testingDate = 0;

            //act
            var result = DateTimeHelper.GetUtcTime(testingDate);

            //assert
            Assert.AreEqual("1/1/1970 12:00:00 AM", result);
        }

        [Test]
        public void Given_MinusValueCorrectSampleTestingDateInUnixFormat_Then_ReturnsStringDataAsExpected()
        {
            //arrange
            var testingDate = -321321321;

            //act
            var result = DateTimeHelper.GetUtcTime(testingDate);

            //assert
            Assert.AreEqual("12/28/1969 6:44:38 AM", result);
        }
    }
}
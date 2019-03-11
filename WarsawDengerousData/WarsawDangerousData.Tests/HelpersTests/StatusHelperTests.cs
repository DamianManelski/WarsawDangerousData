using AutoFixture;
using NUnit.Framework;
using WarsawDengerousData.Helpers;
using WarsawDengerousData.WarsawApiData;

namespace WarsawDangerousData.Tests.WarsawApiData
{
    [TestFixture]
    internal class StatusHelperTests
    {
        private readonly Fixture _fixture = new Fixture();

        [Test]
        public void Given_OneStatusWithValidData_Then_Returns_CorrectStatusString()
        {
            //arrange
            var testingChangeDate = _fixture.Create<long>();
            var testingDescription = _fixture.Create<string>();
            var testingStatus = _fixture.Create<string>();

            var testinStatusObject = new Status
            {
                ChangeDate = testingChangeDate,
                Description = testingDescription,
                StatusStatus = testingStatus
            };

            //act
            var result = StatusHelper.GetStatusesAsString(new Status[] { testinStatusObject });

            //assert
            Assert.AreEqual($"Status:{testingStatus}, Description:{testingDescription}, ChangeDate: {DateTimeHelper.GetUtcTime(testingChangeDate)}\r\n", result);
        }

        [Test]
        public void Given_OneStatusEmptyData_Then_Returns_CorrectStatusString()
        {
            //arrange

            var testinStatusObject = new Status();

            //act
            var result = StatusHelper.GetStatusesAsString(new Status[] { testinStatusObject });

            //assert
            Assert.AreEqual($"Status:, Description:, ChangeDate: 1/1/1970 12:00:00 AM\r\n", result);
        }

        [Test]
        public void Given_TwoStatusesWithValidData_Then_Returns_CorrectStatusString()
        {
            //arrange
            var testingChangeDate = _fixture.Create<long>();
            var testingDescription = _fixture.Create<string>();
            var testingStatus = _fixture.Create<string>();

            var firstTestinStatusObject = new Status
            {
                ChangeDate = testingChangeDate,
                Description = testingDescription,
                StatusStatus = testingStatus
            };

            var secondTestingChangeDate = _fixture.Create<long>();
            var secondTestingDescription = _fixture.Create<string>();
            var secondTestingStatus = _fixture.Create<string>();

            var secondTestinStatusObject = new Status
            {
                ChangeDate = secondTestingChangeDate,
                Description = secondTestingDescription,
                StatusStatus = secondTestingStatus
            };

            //act
            var result = StatusHelper.GetStatusesAsString(new Status[] {
                firstTestinStatusObject, secondTestinStatusObject });

            //assert
            Assert.AreEqual($"Status:{testingStatus}, Description:{testingDescription}, ChangeDate: {DateTimeHelper.GetUtcTime(testingChangeDate)}\r\n" +
                $"Status:{ secondTestingStatus}, Description:{ secondTestingDescription}, ChangeDate: { DateTimeHelper.GetUtcTime(secondTestingChangeDate)}\r\n", result);
        }
    }
}
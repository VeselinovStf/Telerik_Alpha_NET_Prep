using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Mobile;
using System;

namespace MobilePhone.Tests
{
    [TestClass]
    public class BatteryTests
    {
        [TestMethod]
        public void BatteryCtorWithModelMustThrowExceptionWhenModelIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => new Battery(null));
        }

        [TestMethod]
        public void BatteryCtorWithModelMustThrowExceptionWhenModelIsEmptyString()
        {
            Assert.ThrowsException<ArgumentException>(() => new Battery(string.Empty));
        }

        [TestMethod]
        public void BatteryCtorWithModelMustThrowExceptionWhenModelIsWhiteSpace()
        {
            Assert.ThrowsException<ArgumentException>(() => new Battery("  "));
        }

        [TestMethod]
        public void BatteryShoudThrowExceptioForLessThenZeroHourseIdle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Battery("something", -1));
        }

        [TestMethod]
        public void BatteryShoudThrowExceptioForLessThenZeroHourseTalk()
        {
            Assert.ThrowsException<ArgumentException>(() => new Battery("something", 1, -1));
        }

        [TestMethod]
        public void BatteryShoudThrowExceptionIfHourseTalkIsSetToNegativeValue()
        {
            Battery battery = new Battery("something", 1, 1);

            Assert.ThrowsException<ArgumentException>(() => battery.AddTalkTime(-1));
        }
    }
}
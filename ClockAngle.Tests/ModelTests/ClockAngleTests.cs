using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle;

namespace ClockAngle.Test
{
  [TestClass]
  public class ClockTest
  {
    [TestMethod]
    public void Time_HoursLessThan6MinutesIs0_True()
    {
      Clock newTime = new Clock();
      Assert.AreEqual(150, newTime.GetAngle(5, 00));
    }
    [TestMethod]
    public void Time_HoursPast6MinutesIs0_True()
    {
      Clock newTime = new Clock();
      Assert.AreEqual(90, newTime.GetAngle(9, 00));
    }
    [TestMethod]
    public void Time_HoursIs12_True()
    {
      Clock newTime = new Clock();
      Assert.AreEqual(67.5, newTime.GetAngle(5, 15));
    }
  }
}

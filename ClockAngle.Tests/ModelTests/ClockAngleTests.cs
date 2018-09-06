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
    public void Time_Test1_True()
    {
      Clock newTime = new Clock();
      Assert.AreEqual((double)67.5, newTime.GetAngle(5, 15));
    }
    [TestMethod]
    public void Time_Test2_True()
    {
      Clock newTime = new Clock();
      Assert.AreEqual((double)51.5, newTime.GetAngle(8, 53));
    }
    [TestMethod]
    public void Time_Test3_True()
    {
      Clock newTime = new Clock();
      Assert.AreEqual(80, newTime.GetAngle(10, 40));
    }
  }
}

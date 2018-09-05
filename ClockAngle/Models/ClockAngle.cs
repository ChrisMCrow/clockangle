using System;
using System.Collections.Generic;

namespace ClockAngle
{
  public class Clock
  {
    public int GetAngle(int hours, int minutes)
    {
      if (minutes == 0)
      {
        if (hours > 6)
        {
          return (12 - hours) * 30;
        }
        else
        {
          return hours * 30;
        }
      }
      else if (hours <= 12 && minutes <= 60)
      {
        return Math.Abs((hours/12*360)-(((minutes/60)*360)-(.5*minutes)));
      }
      else
      {
        return 361;
      }
    }
  }
}

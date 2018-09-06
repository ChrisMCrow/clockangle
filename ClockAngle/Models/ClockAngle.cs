using System;
using System.Collections.Generic;

namespace ClockAngle
{
  public class Clock
  {
    public double GetAngle(int hours, int minutes)
    {
      double minuteHand = minutes * 6;
      double hourHand = (double)(hours * 60 + minutes) / 2;
      double angle = Math.Abs(minuteHand - hourHand);
      if (angle > 180)
      {
        return 360 - angle;
      }
      else
      {
        return angle;
      }
    }
  }
}

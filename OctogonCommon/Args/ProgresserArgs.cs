using System;

namespace PerformoutCommon.Args
{
   public class ProgresserArgs : EventArgs
   {
      public double Pct { get; set; }
      public string EventName { get; set; }

      public ProgresserArgs(string eventName, double pct)
      {
         Pct = pct;
         EventName = eventName;
      }
   }
}
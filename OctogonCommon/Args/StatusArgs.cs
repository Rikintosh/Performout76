using System;

namespace PerformoutCommon.Args
{
   public class StatusArgs : EventArgs
   {
      public int Status { get; set; }

      public StatusArgs(int status)
      {
         Status = status;
      }
   }
}
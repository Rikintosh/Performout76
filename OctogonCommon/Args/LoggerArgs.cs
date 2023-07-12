using System;
using PerformoutCommon.Statics;

namespace PerformoutCommon.Args
{
   public class LoggerArgs : EventArgs
   {
      public string Text { get; set; }
      public TypeLog TypeLog { get; set; }

      public LoggerArgs(string text, TypeLog typeLog)
      {
         Text = text;
         TypeLog = typeLog;
      }
   }
}
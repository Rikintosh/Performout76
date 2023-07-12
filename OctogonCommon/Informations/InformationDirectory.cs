#region Dependencies

using System.IO;

#endregion

namespace PerformoutCommon.Informations
{
   public class InformationDirectory
   {
      public DirectoryInfo DirectoryInfo { get; set; }

      public double NewSize { get; set; }

      public double Size { get; set; }
   }
}
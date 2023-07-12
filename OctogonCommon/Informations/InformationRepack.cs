using System.Collections.Generic;
using System.IO;
using PerformoutCommon.Configurations;

namespace PerformoutCommon.Informations
{
   public class InformationRepack
   {      
      public InformationRepack(ConfigurationRepack repack)
      {
         ConfigurationRepack = repack;
         Sources = new List<DirectoryInfo>();
      }


      public ConfigurationRepack ConfigurationRepack { get; set; }
      public List<DirectoryInfo> Sources { get; set; }
   }
}
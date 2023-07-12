using System.IO;

namespace PerformoutCommon.Informations
{
   public class InformationFileDeletion
   {
      public InformationFileDeletion(FileInfo fileToDelete)
      {
         FileToDelete = fileToDelete;       
      }

      public FileInfo FileToDelete { get; private set; }
      
   }
}
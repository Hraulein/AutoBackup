using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBackup.Local
{
    static class FilePath
    {
        private readonly static string AutoBackupRootDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\AutoBackup";
        public readonly static string ConfigFilePath = AutoBackupRootDir + @"\Config";
    }
    class Config
    {
        
    }
}

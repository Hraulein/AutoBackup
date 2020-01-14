using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AutoBackup.Utils
{
    class SystemExtName
    {
        [System.Flags]
        private enum LoadLibraryFlags : uint
        {
            DONT_RESOLVE_DLL_REFERENCES = 0x00000001,
            LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010,
            LOAD_LIBRARY_AS_DATAFILE = 0x00000002,
            LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040,
            LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020,
            LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008,
            LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x00000100,
            LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800,
            LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000
        }

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr LoadLibraryEx(string dllToLoad, IntPtr hFile, LoadLibraryFlags flags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int LoadString(IntPtr hInstance, int ID, StringBuilder lpBuffer, int nBufferMax);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeLibrary(IntPtr hModule);

        private static string ExtractStringFromDLL(string file, int number)
        {
            IntPtr lib = LoadLibraryEx(file, IntPtr.Zero, LoadLibraryFlags.LOAD_LIBRARY_AS_IMAGE_RESOURCE);
            StringBuilder result = new StringBuilder(2048);
            LoadString(lib, number, result, result.Capacity);
            FreeLibrary(lib);
            return result.ToString();
        }

        private static string ParseFriendlyTypeName(string FriendlyTypeName)
        {
            int pos = FriendlyTypeName.LastIndexOf(',');
            if (pos == -1)
            {
                return Environment.ExpandEnvironmentVariables(FriendlyTypeName);
            }
            else
            {
                string libaryFilePath = FriendlyTypeName.Substring(1, pos - 1);
                if (libaryFilePath.StartsWith("\"") && libaryFilePath.EndsWith("\""))
                {
                    libaryFilePath = libaryFilePath.Substring(1, libaryFilePath.Length - 2);
                }
                return ExtractStringFromDLL(Environment.ExpandEnvironmentVariables(libaryFilePath), Math.Abs(Convert.ToInt32(FriendlyTypeName.Substring(pos + 1))));
            }
        }

        /* 根据文件名获取文件后缀友好名称(可以只输入后缀) */
        public static string GetFileExtTypeName(string filename)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(filename);
            string fileExtString = fileInfo.Extension;
            if (string.IsNullOrEmpty(fileExtString))
            {
                return "文件";
            }
            string fileExt = fileExtString.Substring(1).ToUpper();
            RegistryKey subKey;
            try
            {
                subKey = Registry.ClassesRoot.OpenSubKey(fileExtString);
                if (subKey == null)
                {
                    return fileExt + " 文件";
                }
                string ExtName = subKey.GetValue("").ToString();
                subKey.Close();
                if (string.IsNullOrEmpty(ExtName))
                {
                    return fileExt + " 文件";
                }
                subKey = Registry.ClassesRoot.OpenSubKey(ExtName);
                if (subKey == null)
                {
                    return fileExt + " 文件";
                }
                object FriendlyTypeName = subKey.GetValue("FriendlyTypeName");
                if (FriendlyTypeName == null)
                {
                    string ExtNameDes = subKey.GetValue("").ToString();
                    subKey.Close();
                    if (string.IsNullOrEmpty(ExtNameDes))
                    {
                        return fileExt + " 文件";
                    }
                    else
                    {
                        return ExtNameDes;
                    }
                }
                else
                {
                    subKey.Close();
                    return ParseFriendlyTypeName(FriendlyTypeName as string);
                }
            }
            catch(Exception)
            {
                return fileExt + " 文件";
            }
        }
    }
}

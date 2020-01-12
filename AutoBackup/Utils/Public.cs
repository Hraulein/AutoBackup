using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoBackup.Utils
{
    class Public
    {
        /// <summary>
        /// 获取文件大小（字节）
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static long? GetFileLength(string filepath)
        {
            if (File.Exists(filepath))
            {
                FileInfo info = new FileInfo(filepath);
                long filesize = info.Length;
                return filesize ; //返回大小
            }
            else
                return null;
        }
        /// <summary>
        /// 获取文件夹大小(字节)
        /// </summary>
        /// <param name="dirPath">文件夹目录</param>
        /// <returns></returns>
        public static long GetFolderLength(string dirPath)
        {
            long len = 0;
            if (Directory.Exists(dirPath))
            {
                try
                {
                    //定义一个DirectoryInfo对象
                    DirectoryInfo di = new DirectoryInfo(dirPath);
                    //通过GetFiles方法，获取di目录中的所有文件的大小
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        len += fi.Length;
                    }
                    //获取di中所有的文件夹，并存到一个新的对象数组中，以进行递归
                    DirectoryInfo[] dis = di.GetDirectories();
                    if (dis.Length > 0)
                    {
                        for (int i = 0; i < dis.Length; i++)
                        {
                            len += GetFolderLength(dis[i].FullName);
                        }
                    }
                    return len ; //返回
                }
                catch
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}

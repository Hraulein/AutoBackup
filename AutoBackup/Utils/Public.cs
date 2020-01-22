using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using AutoBackup.Extensions;
using System.Security;
using System.Diagnostics;

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
                return filesize; //返回大小
            }
            else
                return null;
        }
        /// <summary>
        /// 获取文件夹大小(字节)
        /// </summary>
        /// <param name="dirPath">文件夹目录</param>
        /// <returns></returns>
        public static Task<long> GetFolderLength(DirectoryInfo di)
        {
            return Task.Run(() =>
            {
                long len = 0;
                try
                {
                    if (!di.Exists)
                    {
                        return 0;
                    }
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        len += fi.Length;
                    }
                    DirectoryInfo[] dis = di.GetDirectories();
                    if (dis != null)
                    {
                        foreach (DirectoryInfo directoryInfo in dis)
                        {
                            len += GetFolderLength(directoryInfo).Result;
                        }
                    }
                    return len;
                }
                catch (IOException e)
                {
                    Trace.TraceError(e.ToString());
                    return 0;
                }
                catch (SecurityException e)
                {
                    Trace.TraceError(e.ToString());
                    return 0;
                }
                catch (UnauthorizedAccessException e)
                {
                    Trace.TraceError(e.ToString());
                    return 0;
                }
            });
        }
    }
}

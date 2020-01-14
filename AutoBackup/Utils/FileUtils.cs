namespace AutoBackup.Utils
{
    class FileUtils
    {
        /// <summary>
        /// 文件大小的转换
        /// </summary>
        /// <param name="size">文件的大小(字节)</param>
        /// <returns></returns>
        public static string GetSizeString(long size)
        {
            if (size < 1024 && size != 0)
            {
                return "1 KB";
            }
            return string.Format("{0:N0}", size / 1024) + " KB";
        }
    }
}

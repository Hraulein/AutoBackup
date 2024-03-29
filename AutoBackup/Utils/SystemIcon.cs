﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AutoBackup.Utils
{
    class SystemIcon
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }
        [DllImport("Shell32.dll", EntryPoint = "SHGetFileInfo", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);
        [DllImport("User32.dll", EntryPoint = "DestroyIcon")]
        private static extern int DestroyIcon(IntPtr hIcon);
        #region API 参数的常量定义
        private enum FileInfoFlags : uint
        {
            SHGFI_ICON = 0x000000100, // get icon
            SHGFI_DISPLAYNAME = 0x000000200, // get display name
            SHGFI_TYPENAME = 0x000000400, // get type name
            SHGFI_ATTRIBUTES = 0x000000800, // get attributes
            SHGFI_ICONLOCATION = 0x000001000, // get icon location
            SHGFI_EXETYPE = 0x000002000, // return exe type
            SHGFI_SYSICONINDEX = 0x000004000, // get system icon index
            SHGFI_LINKOVERLAY = 0x000008000, // put a link overlay on icon
            SHGFI_SELECTED = 0x000010000, // show icon in selected state
            SHGFI_ATTR_SPECIFIED = 0x000020000, // get only specified attributes
            SHGFI_LARGEICON = 0x000000000, // get large icon
            SHGFI_SMALLICON = 0x000000001, // get small icon
            SHGFI_OPENICON = 0x000000002, // get open icon
            SHGFI_SHELLICONSIZE = 0x000000004, // get shell size icon
            SHGFI_PIDL = 0x000000008, // pszPath is a pidl
            SHGFI_USEFILEATTRIBUTES = 0x000000010, // use passed dwFileAttribute
            SHGFI_ADDOVERLAYS = 0x000000020, // apply the appropriate overlays
            SHGFI_OVERLAYINDEX = 0x000000040 // Get the index of the overlay
        }
        private enum FileAttributeFlags : uint
        {
            FILE_ATTRIBUTE_READONLY = 0x00000001,
            FILE_ATTRIBUTE_HIDDEN = 0x00000002,
            FILE_ATTRIBUTE_SYSTEM = 0x00000004,
            FILE_ATTRIBUTE_DIRECTORY = 0x00000010,
            FILE_ATTRIBUTE_ARCHIVE = 0x00000020,
            FILE_ATTRIBUTE_DEVICE = 0x00000040,
            FILE_ATTRIBUTE_NORMAL = 0x00000080,
            FILE_ATTRIBUTE_TEMPORARY = 0x00000100,
            FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200,
            FILE_ATTRIBUTE_REPARSE_POINT = 0x00000400,
            FILE_ATTRIBUTE_COMPRESSED = 0x00000800,
            FILE_ATTRIBUTE_OFFLINE = 0x00001000,
            FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 0x00002000,
            FILE_ATTRIBUTE_ENCRYPTED = 0x00004000
        }
        #endregion
        /// <summary>
        /// 获取文件类型的关联图标
        /// </summary>
        /// <param name="fileName">文件类型的扩展名或文件的绝对路径</param>
        /// <param name="isLargeIcon">是否返回大图标</param>
        /// <returns>获取到的图标</returns>
        public static Icon GetIcon(string fileName, bool isLargeIcon)
        {
            SHFILEINFO shfi = new SHFILEINFO();
            IntPtr hI;
            if (isLargeIcon)
                hI = SHGetFileInfo(fileName, 0, ref shfi, (uint)Marshal.SizeOf(shfi), (uint)FileInfoFlags.SHGFI_ICON | (uint)FileInfoFlags.SHGFI_USEFILEATTRIBUTES | (uint)FileInfoFlags.SHGFI_LARGEICON);
            else
                hI = SHGetFileInfo(fileName, 0, ref shfi, (uint)Marshal.SizeOf(shfi), (uint)FileInfoFlags.SHGFI_ICON | (uint)FileInfoFlags.SHGFI_USEFILEATTRIBUTES | (uint)FileInfoFlags.SHGFI_SMALLICON);
            Icon icon = Icon.FromHandle(shfi.hIcon).Clone() as Icon;
            DestroyIcon(shfi.hIcon); //释放资源
            return icon;
        }

        /// <summary>
        /// 获取磁盘驱动器图标
        /// </summary>
        /// <param name="driverMark">有效的磁盘标号，如C、D、I等等，不区分大小写</param>
        /// <param name="isSmallIcon">标识是获取小图标还是获取大图标</param>
        /// <returns>返回一个Icon类型的磁盘驱动器图标对象</returns>
        public static Icon GetDriverIcon(char driverMark, bool isSmallIcon)
        {
            if (driverMark < 'a' && driverMark > 'z' && driverMark < 'A' && driverMark > 'Z')
            {
                return null;
            }
            string driverName = $"{char.ToUpper(driverMark)}:\\";

            SHFILEINFO shfi = new SHFILEINFO();
            FileInfoFlags uFlags = FileInfoFlags.SHGFI_ICON | FileInfoFlags.SHGFI_SHELLICONSIZE | FileInfoFlags.SHGFI_USEFILEATTRIBUTES;
            if (isSmallIcon)
                uFlags |= FileInfoFlags.SHGFI_SMALLICON;
            else
                uFlags |= FileInfoFlags.SHGFI_LARGEICON;
            int iTotal = (int)SHGetFileInfo(driverName, (uint)FileAttributeFlags.FILE_ATTRIBUTE_NORMAL, ref shfi, (uint)Marshal.SizeOf(shfi), (uint)uFlags);
            //int iTotal = (int)SHGetFileInfo(driverName, 0, ref shfi, (uint)Marshal.SizeOf(shfi), uFlags);
            Icon icon = null;
            if (iTotal > 0)
            {
                icon = Icon.FromHandle(shfi.hIcon).Clone() as Icon;
            }
            DestroyIcon(shfi.hIcon); //释放资源
            return icon;
        }

        /// <summary>
        /// 获取磁盘驱动器图标
        /// </summary>
        /// <param name="driverRoot">有效的磁盘根目录字符串，如C:\、D:\、I:\等等，不区分大小写</param>
        /// <param name="isSmallIcon">标识是获取小图标还是获取大图标</param>
        /// <returns>返回一个Icon类型的磁盘驱动器图标对象</returns>
        public static Icon GetDriverIcon(string driverRoot, bool isSmallIcon)
        {
            if (!string.IsNullOrEmpty(driverRoot) && driverRoot.Length == 3 && driverRoot[0] < 'a' && driverRoot[0] > 'z' && driverRoot[0] < 'A' && driverRoot[0] > 'Z' && driverRoot.EndsWith(":\\"))
            {
                return null;
            }

            string driverName = driverRoot.ToUpper();

            SHFILEINFO shfi = new SHFILEINFO();
            FileInfoFlags uFlags = FileInfoFlags.SHGFI_ICON | FileInfoFlags.SHGFI_SHELLICONSIZE | FileInfoFlags.SHGFI_USEFILEATTRIBUTES;
            if (isSmallIcon)
                uFlags |= FileInfoFlags.SHGFI_SMALLICON;
            else
                uFlags |= FileInfoFlags.SHGFI_LARGEICON;
            int iTotal = (int)SHGetFileInfo(driverName, (uint)FileAttributeFlags.FILE_ATTRIBUTE_NORMAL, ref shfi, (uint)Marshal.SizeOf(shfi), (uint)uFlags);
            //int iTotal = (int)SHGetFileInfo(driverName, 0, ref shfi, (uint)Marshal.SizeOf(shfi), uFlags);
            Icon icon = null;
            if (iTotal > 0)
            {
                icon = Icon.FromHandle(shfi.hIcon).Clone() as Icon;
            }
            DestroyIcon(shfi.hIcon); //释放资源
            return icon;
        }


        /// <summary> 
        /// 获取文件夹图标
        /// </summary> 
        /// <returns>图标</returns> 
        public static Icon GetDirectoryIcon(bool isLargeIcon)
        {
            SHFILEINFO _SHFILEINFO = new SHFILEINFO();
            IntPtr _IconIntPtr;
            if (isLargeIcon)
            {
                _IconIntPtr = SHGetFileInfo(@"", 0, ref _SHFILEINFO, (uint)Marshal.SizeOf(_SHFILEINFO), ((uint)FileInfoFlags.SHGFI_ICON | (uint)FileInfoFlags.SHGFI_LARGEICON));
            }
            else
            {
                _IconIntPtr = SHGetFileInfo(@"", 0, ref _SHFILEINFO, (uint)Marshal.SizeOf(_SHFILEINFO), ((uint)FileInfoFlags.SHGFI_ICON | (uint)FileInfoFlags.SHGFI_SMALLICON));
            }
            if (_IconIntPtr.Equals(IntPtr.Zero)) return null;
            Icon _Icon = System.Drawing.Icon.FromHandle(_SHFILEINFO.hIcon);
            return _Icon;
        }
    }
}

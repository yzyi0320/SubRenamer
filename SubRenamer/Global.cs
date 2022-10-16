﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubRenamer
{
    public class Global
    {
        #region 常量
        public static readonly string LOG_FILENAME = Path.Combine(Application.StartupPath, $"{Program.GetAppName()}.log");
        public static readonly List<string> VideoExts = new List<string> { ".mkv", ".mp4", "flv", ".avi", ".mov", ".rmvb", ".wmv", ".mpg", ".avs" , ".m4v", ".wav", ".mp3"};
        public static readonly List<string> SubExts = new List<string> { ".srt", ".ass", ".ssa", ".sub", ".idx", ".lrc", ".xml", ".smi" , ".vtt"};
        #endregion

        /// <summary>
        /// 文件类型
        /// </summary>
        public enum AppFileType
        {
            Video,
            Sub
        }
    }
}

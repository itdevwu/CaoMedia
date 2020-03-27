using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace CaoMedia
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }

    class ConvertMissionClass
    {
        public string inputFilePathName;
        public string outputFilePath;

        public int outputFormat;

        public bool ultraFastMode = false;

        /*
        public static int hwAccelDevice = 0;

        public static int inputAudioStream;
        public static int outputAudioStream;

        public static int inputVideoStream;
        public static int outputVideoStream;

        public static int mediaBitrate;

        public static int inputFPS;
        public static int outputFPS;
        public static bool motionInterpolation = false;
        */

        private string outputSuffix()
        {
            string Suffix = "";

            // Video format
            if (outputFormat == 1)
            {
                Suffix = ".mp4";
            }

            if (outputFormat == 2)
            {
                Suffix = ".hevc";
            }

            if (outputFormat == 3)
            {
                Suffix = ".wmv";
            }

            if (outputFormat == 4)
            {
                Suffix = ".mov";
            }

            if (outputFormat == 5)
            {
                Suffix = ".m4v";
            }

            if (outputFormat == 6)
            {
                Suffix = ".avi";
            }

            if (outputFormat == 7)
            {
                Suffix = ".mkv";
            }

            //Audio format
            if (outputFormat == 8)
            {
                Suffix = ".flac";
            }

            if (outputFormat == 9)
            {
                Suffix = ".mp3";
            }

            if (outputFormat == 10)
            {
                Suffix = ".ogg";
            }

            if (outputFormat == 11)
            {
                Suffix = ".aac";
            }

            return Suffix;
        }

        private string fileNameWithoutPath()
        {
            string _tmp = inputFilePathName;
            int _pos = _tmp.Length - 1;

            while (_tmp[_pos] != '\\')
            {
                _pos--;
            }

            string fileNameWithoutPath = _tmp.Substring(_pos);

            return fileNameWithoutPath;
        }

        private string ffmpegArgsGenerate()
        {
            string ffmpegArgs = "";
            ffmpegArgs += " -i ";
            ffmpegArgs += inputFilePathName;
            ffmpegArgs += " -threads 0 ";
            if (ultraFastMode == true)
            {
                ffmpegArgs += " -c:a copy -c:v copy ";
            }
            ffmpegArgs += outputFilePath;
            ffmpegArgs += fileNameWithoutPath();
            ffmpegArgs += ".out";
            ffmpegArgs += outputSuffix();

            return ffmpegArgs;
        }

        public bool ffmpegConvert(/*DataReceivedEventHandler ffmpegOutput*/)
        {
            bool ffmpegError = true;

            // New process
            Process ffmpegProcess = new Process();
            ffmpegProcess.StartInfo.FileName = "ffmpeg.exe";
            ffmpegProcess.StartInfo.Arguments = ffmpegArgsGenerate();

            // No Windows shell and new window
            ffmpegProcess.StartInfo.UseShellExecute = false;
            ffmpegProcess.StartInfo.CreateNoWindow = true;

            // Output & Error redirect
            ffmpegProcess.StartInfo.RedirectStandardOutput = true;
            ffmpegProcess.StartInfo.RedirectStandardError = true;

            // Output & Error message receive
            // ffmpegProcess.OutputDataReceived += ffmpegOutput;
            // ffmpegProcess.ErrorDataReceived += ffmpegOutput;

            // Run process
            ffmpegProcess.Start();
            ffmpegProcess.BeginOutputReadLine();
            ffmpegProcess.BeginErrorReadLine();
            ffmpegProcess.WaitForExit();

            return ffmpegError;
        }
    }
}

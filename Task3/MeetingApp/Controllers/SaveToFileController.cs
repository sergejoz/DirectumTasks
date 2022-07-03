using MeetingApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using static System.DateTime;

namespace MeetingApp.Controllers
{
    public static class SaveToFileController
    {
        public static void Execute(List<Meeting> meetings)
        {
            PrintController.Execute("Хотите сохранить список в файл? (y/n)");
            var answer = ReadController.ReadLine();

            if (answer == "y")
            {
                using (var fileStream = File.Open(GetDirectory(), FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                {
                    using (var log = new StreamWriter(fileStream))
                    {
                        foreach (var s in meetings)
                            log.WriteLine(s.ToString());
                    }
                }
                PrintController.Execute("Файл сохранен!");
            }
        }

        private static string GetDirectory()
        {
            var logPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Meetings\\Meetings" + Today.ToString("yyyy-MM-dd") + "." + "txt";
            var logFileInfo = new FileInfo(logPath);
            var logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();

            return logPath;
        }
    }
}

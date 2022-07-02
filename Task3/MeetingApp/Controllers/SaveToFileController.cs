using MeetingApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                using (TextWriter tw = new StreamWriter("Meetings.txt"))
                {
                    foreach (var s in meetings)
                        tw.WriteLine(s.ToString());
                }

                PrintController.Execute("Файл успешно сохранен!");
            }

        }
    }
}

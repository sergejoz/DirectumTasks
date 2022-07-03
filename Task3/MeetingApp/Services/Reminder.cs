using MeetingApp.Controllers;
using MeetingApp.MenuCommands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MeetingApp.Services
{
    public class Reminder
    {
        private BackgroundWorker worker;

        public Reminder()
        {
            worker = new BackgroundWorker()
            {
                WorkerSupportsCancellation = true,
            };
            worker.DoWork += worker_DoWork;

            var timer = new Timer(60000);
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var dateNow = DateTime.Now;
            var dateNoSeconds = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.Hour, dateNow.Minute, 0);
            var meetings = Storage.Meetings.Where(x => x.AlertDate == dateNoSeconds).ToList();

            if (meetings.Any())
            {
                PrintController.Execute("=== Напоминания о встречах: ===");
                ShowMeetingsController.PrintMeetings(meetings, true);
                PrintController.Execute("");
            }
        }
    }
}

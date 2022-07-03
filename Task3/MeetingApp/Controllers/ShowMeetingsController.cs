using System.Collections.Generic;
using System.Linq;
using MeetingApp.Model;

namespace MeetingApp.Controllers
{
    public class ShowMeetingsController
    {
        public static void ExecuteShowAll()
        {
            var meetings = Storage.Meetings;
            if (meetings.Any())
                PrintMeetings(meetings, true);
            else
                PrintNoMeetings();
        }

        public static void ExecuteShowSpecifiedDay()
        {
            var date = ReadController.ReadShortDate();
            var meetings = Storage.Meetings.Where(x => x.StartDate.Date == date).ToList();

            if (meetings.Any())
                PrintMeetings(meetings, true);
            else
                PrintNoMeetings();
        }

        public static void PrintNoMeetings()
        {
            PrintController.Execute("Список встреч пуст!");
        }

        public static void PrintMeetings(List<Meeting> meetings, bool isSaving = false)
        {
            ClearController.Clear();
            meetings.ForEach(x => PrintController.Execute(x.ToString()));
            if (isSaving) SaveToFileController.Execute(meetings);
        }

        public static void PrintAlertMeetings(List<Meeting> meetings)
        {
            PrintController.Execute("=== Напоминание о встречах: ===");
            meetings.ForEach(x => PrintController.Execute(x.ToString()));
            PrintController.Execute("");
        }
    }
}

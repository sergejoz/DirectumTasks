using System;
using System.Collections.Generic;
using System.Linq;
using MeetingApp.Controllers;
using MeetingApp.Menu;
using MeetingApp.Model;

namespace MeetingApp.MenuCommands
{
    public class ShowMeetingsController
    {
        internal static void ExecuteShowAll()
        {
            var meetings = Storage.Meetings;
            if (meetings.Any())
                PrintMeetings(meetings);
            else
                PrintController.Execute("Список встреч пуст!");
        }

        internal static void ExecuteShowSpecifiedDay()
        {
            PrintController.Execute("Введите число в формате dd.mm.yyyy");
            var date = ReadController.ReadShortDate();
            var meetings = Storage.Meetings.Where(x => x.StartDate.Date == date).ToList();

            if (meetings.Any())
                PrintMeetings(meetings);
            else
                PrintController.Execute("Список встреч пуст!");
        }

        public static void PrintMeetings(List<Meeting> meetings, bool alert = false)
        {
            meetings.ForEach(x => Console.WriteLine(x.ToString()));
            if (!alert)
                SaveToFileController.Execute(meetings);
        }
    }
}

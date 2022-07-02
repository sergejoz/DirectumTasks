using System;
using System.Collections.Generic;
using System.Globalization;
using MeetingApp.Controllers;
using MeetingApp.Menu;
using MeetingApp.Model;

namespace MeetingApp.MenuCommands
{
    public class CreateNewMeetingController
    {
        internal static void Execute()
        {
            PrintController.Execute("Введите название встречи:");
            var name = ReadController.ReadLine();

            PrintController.Execute("Введите дату и время начала встречи в формате dd.mm.yyyy hh:mm:");
            var startDate = ReadController.ReadFullDate();

            PrintController.Execute("Введите дату и время окончания встречи в формате dd.mm.yyyy hh:mm:");
            var endDate = ReadController.ReadFullDate();

            PrintController.Execute("Введите время в минутах, за сколько до начала встречи сделать уведомление:");
            var alertTime = ReadController.ReadInt();

            if (endDate < startDate)
            {
                PrintController.Execute("Встреча не может закончится до ее начала");
            }

            var meeting = new Meeting(name, startDate, endDate, startDate.AddMinutes(-alertTime));
            Storage.Storage.Meetings.Add(meeting);
            PrintController.Execute("Встреча была добавлена!");
        }
    }
}

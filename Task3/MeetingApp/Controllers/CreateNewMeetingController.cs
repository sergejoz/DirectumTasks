using System;
using System.Collections.Generic;
using System.Globalization;
using MeetingApp.Controllers;
using MeetingApp.Menu;
using MeetingApp.Model;

namespace MeetingApp.Controller
{
    public class CreateNewMeetingController
    {
        internal static void Execute()
        {
            var meeting = new Meeting();
            meeting.SetName();
            meeting.SetDates();

            Storage.Meetings.Add(meeting);
            ClearController.Clear();
            PrintController.Execute("Встреча была добавлена!");
        }
    }
}

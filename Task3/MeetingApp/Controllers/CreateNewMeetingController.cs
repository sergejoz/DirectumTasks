using MeetingApp.Model;

namespace MeetingApp.Controllers
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

using MeetingApp.Controller;
using System.Linq;

namespace MeetingApp.Controllers
{
    public class DeleteMeetingController
    {
        public static void Execute()
        {
            var meetings = Storage.Meetings;
            ShowMeetingsController.PrintMeetings(meetings);
            PrintController.Execute("Введите Id встречи, которую хотите удалить");
            var meetId = ReadController.ReadInt();
            var meeting = meetings.FirstOrDefault(x => x.Id == meetId);
            if (meetings != null)
            {
                Storage.Meetings.Remove(meeting);
                ClearController.Clear();
                PrintController.Execute("Встреча удалена");
            }
            else PrintController.Execute("Встречи с таким ID не существует");
        }
    }
}

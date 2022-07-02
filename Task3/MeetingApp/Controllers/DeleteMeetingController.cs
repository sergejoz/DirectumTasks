using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp.Controllers
{
    public class DeleteMeetingController
    {
        public static void Execute()
        {
            var meetings = Storage.Meetings;
            PrintController.Execute("Введите Id встречи, которую хотите удалить");
            var meetId = ReadController.ReadInt();
            var meeting = meetings.FirstOrDefault(x => x.Id == meetId);
            if (meetings != null)
            {
                Storage.Meetings.Remove(meeting);
                PrintController.Execute("Встреча удалена");
            }
            else PrintController.Execute("Встречи с таким ID не существует");
        }
    }
}

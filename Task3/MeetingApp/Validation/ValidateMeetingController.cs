using MeetingApp.Controllers;
using MeetingApp.Model;
using System.Linq;

namespace MeetingApp.Validation
{
    public class ValidateMeetingController
    {
        public static bool CheckMeeting(Meeting meeting)
        {
           var datesOverlap = Storage.Meetings.Any(x => meeting != x && meeting.StartDate <= x.EndDate && meeting.EndDate >= x.StartDate);

            if (datesOverlap)
            {
                PrintController.Execute("Обнаружено пересечение встреч! Введите даты снова.");
            }

            return datesOverlap;
        }
    }
}

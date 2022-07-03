using MeetingApp.Controllers;
using MeetingApp.Model;
using MeetingApp.Validation;
using System.Collections.Generic;
using System.Linq;

namespace MeetingApp.Controller
{
    public class EditMeetingController
    {
        private static List<string> fields = new List<string>() {
            "1. Название",
            "2. Дата начала",
            "3. Дата окончания",
            "4. Дата напоминания"
        };

        public static void Execute()
        {
            var meetings = Storage.Meetings;
            ShowMeetingsController.PrintMeetings(meetings);
            PrintController.Execute("Введите Id встречи, которую хотите изменить");
            var meetId = ReadController.ReadInt();
            var meeting = meetings.FirstOrDefault(x => x.Id == meetId);
            if (meeting != null)
                SelectField(meeting);
            else PrintController.Execute("Встречи с таким ID не существует");
        }

        private static void SelectField(Meeting meeting)
        {
            fields.ForEach(x=> PrintController.Execute(x));
            PrintController.Execute("Выберите номер редактируемого поля");
            var fieldId = ReadController.ReadInt();

            switch (fieldId)
            {
                case 1:
                    meeting.SetName();
                    break;
                case 2:
                    {
                        do
                        {
                            meeting.SetStartDate();
                        }
                        while (ValidateMeetingController.CheckMeeting(meeting) == true);
                    }
                    break;
                case 3:
                    {
                        do
                        {
                            meeting.SetEndDate();
                        }
                        while (ValidateMeetingController.CheckMeeting(meeting) == true);
                    }
                    break;
                case 4:
                    meeting.SetAlertDate();
                    break;
                default: 
                    PrintController.Execute("Поля с таким номером не существует!");
                    break;
            }

            PrintController.Execute("Поле изменено!");

        }


    }
}

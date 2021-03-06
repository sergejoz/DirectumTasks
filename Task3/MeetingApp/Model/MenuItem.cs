using MeetingApp.Controllers;

namespace MeetingApp.Model
{
    public class MenuItem
    {
        public int Oid;
        private string Name;

        public MenuItem(int oid, string name)
        {
            Oid = oid;
            Name = name;
        }

        public void Execute()
        {
            switch (Oid)
            {
                case 1:
                    ShowMeetingsController.ExecuteShowAll();
                    break;
                case 2:
                    ShowMeetingsController.ExecuteShowSpecifiedDay();
                    break;
                case 3:
                    CreateNewMeetingController.Execute();
                    break;
                case 4:
                    EditMeetingController.Execute();
                    break;
                case 5:
                    DeleteMeetingController.Execute();
                    break;
                default:
                    PrintController.Execute("Такой команды не существует!");
                    break;
            }
        }

        public override string ToString() => ($"{Oid}. {Name}");
    }
}

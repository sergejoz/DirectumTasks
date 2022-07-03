using MeetingApp.Services;

namespace MeetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reminder reminder = new Reminder();
            reminder.Run();
            MenuWorker.Run();
        }
    }
}


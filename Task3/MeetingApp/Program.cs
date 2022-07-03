using MeetingApp.Services;

namespace MeetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reminder = new Reminder();
            reminder.Run();
            MenuWorker.Run();
        }
    }
}


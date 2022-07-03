using MeetingApp.Services;
using System;

namespace MeetingApp.Controllers
{
    public class ClearController
    {
        public static void Clear()
        {
            Console.Clear();
            MenuWorker.PrintMenu();
        }

    }
}

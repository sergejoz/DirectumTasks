using System.Collections.Generic;
using MeetingApp.Model;

namespace MeetingApp
{
    /// <summary>
    /// вместо бд
    /// </summary>
    public static class Storage
    {
        static List<Meeting> meetings = new List<Meeting>();

        public static List<Meeting> Meetings => meetings;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp.Model
{
    public class Meeting
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AlertDate { get; set; }

        public Meeting(string name, DateTime start, DateTime end, DateTime alertDate)
        {
            Name = name;
            StartDate = start;
            EndDate = end;
            AlertDate = alertDate;
        }

        public override string ToString() => $"Название: {Name}, Начало: {StartDate:g}, Окончание: {EndDate:g}, Напоминание в: {AlertDate:g}";
    }
}

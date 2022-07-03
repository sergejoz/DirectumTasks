using MeetingApp.Controllers;
using MeetingApp.Entities;
using MeetingApp.Validation;
using System;

namespace MeetingApp.Model
{
    public class Meeting
    {
        private int id;
        public int Id => id;
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AlertDate { get; set; }

        public Meeting()
        {
            id = AutoIncrement.GenerateId();
        }

        public override string ToString() => $"ID = {Id}, Название: {Name}, Начало: {StartDate:g}, Окончание: {EndDate:g}, Напоминание в: {AlertDate:g}";

        public void SetDates()
        {
            do
            {
                SetStartDate();
                SetEndDate();
                SetAlertDate();
            }
            while (ValidateMeetingController.CheckMeeting(this) == true);
        }


        public void SetName()
        {
            PrintController.Execute("Введите Название встречи:");
            var input = ReadController.ReadLine();
            Name = input;
        }

        public void SetStartDate()
        {
            PrintController.Execute("Дата Начала:");
            var startDate = ReadController.ReadFullDate();
            StartDate = startDate;
        }

        public void SetEndDate()
        {
            PrintController.Execute("Дата Окончания:");
            var endDate = ReadController.ReadFullDate();
            EndDate = endDate;
        }

        public void SetAlertDate()
        {
            PrintController.Execute("Введите время в минутах, за сколько до начала встречи сделать уведомление:");
            var alertTime = ReadController.ReadInt();
            AlertDate = StartDate.AddMinutes(-alertTime);
        }
    }
}

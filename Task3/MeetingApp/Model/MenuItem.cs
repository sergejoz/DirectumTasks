﻿using System;
using System.Collections.Generic;
using MeetingApp.Controllers;
using MeetingApp.MenuCommands;
using MeetingApp.Model;

namespace MeetingApp.Menu
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
                    CreateNewMeetingController.Execute();
                    break;
                case 2:
                    ShowMeetingsController.ExecuteShowAll();
                    break;
                case 3:
                    ShowMeetingsController.ExecuteShowSpecifiedDay();
                    break;
                default:
                    PrintController.Execute("Такой команды не существует!");
                    break;
            }
        }

        public override string ToString() => ($"{Oid} {Name}");
    }
}

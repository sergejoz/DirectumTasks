using MeetingApp.Controllers;
using MeetingApp.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp.Services
{
    public static class MenuWorker
    {
        private static List<MenuItem> menuItems = new List<MenuItem>();

        public static void Run()
        {
            CreateMenu();

            while (true)
            {
                var commandNumber = ReadController.ReadInt();
                MenuItemExecute(commandNumber);
            }
        }

        private static void CreateMenu()
        {
            menuItems.Add(new MenuItem(1, "Создать встречу"));
            menuItems.Add(new MenuItem(2, "Посмотреть все встречи"));
            menuItems.Add(new MenuItem(3, "Посмотреть встречи на конкретный день"));
            menuItems.ForEach(x => Console.WriteLine(x.ToString()));
        }


        private static void MenuItemExecute(int menuNumber)
        {
            var menuItem = menuItems.FirstOrDefault(x => x.Oid == menuNumber);

            if (menuItem == null)
                PrintController.Execute("Такого пункта меню не существует!");
            else
                menuItem.Execute();
        }
    }
}

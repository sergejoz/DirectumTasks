using MeetingApp.Controllers;
using MeetingApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace MeetingApp.Services
{
    public static class MenuWorker
    {
        private static List<MenuItem> menuItems = new List<MenuItem>();

        public static void Run()
        {
            CreateMenu();
            PrintMenu();
            while (true)
            {
                var commandNumber = ReadController.ReadInt();
                MenuItemExecute(commandNumber);
            }
        }

        private static void CreateMenu()
        {
            menuItems.Add(new MenuItem(1, "Посмотреть все встречи"));
            menuItems.Add(new MenuItem(2, "Посмотреть встречи на конкретный день"));
            menuItems.Add(new MenuItem(3, "Создать встречу"));
            menuItems.Add(new MenuItem(4, "Изменить встречу"));
            menuItems.Add(new MenuItem(5, "Удалить встречу"));
        }

        public static void PrintMenu()
        {
            PrintController.Execute("======= Меню =======");
            menuItems.ForEach(x => PrintController.Execute(x.ToString()));
            PrintController.Execute("====================");
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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp.Controllers
{
    public static class ReadController
    {
        public static string ReadLine() => Console.ReadLine();

        public static int ReadInt()
        {
            while (true)
            {
                var isParsed = int.TryParse(ReadLine(), out var commandNumber);
                if (isParsed)
                {
                    return commandNumber;
                }
                else
                {
                    PrintController.Execute("Число введено неверно!");
                }
            }
        }

        public static DateTime ReadFullDate()
        {
            while (true)
            {
                PrintController.Execute("(введите дату и время в формате dd.mm.yyyy hh:mm)");
                var input = ReadLine();
                var isParsed = DateTime.TryParseExact(input, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result);

                if (isParsed && result > DateTime.Now)
                {
                    return result;
                }

                if (isParsed && result < DateTime.Now)
                {
                    PrintController.Execute("Дата может не может быть в прошлом");
                }

                if (!isParsed)
                {
                    PrintController.Execute("Дата введена неверно");
                }
            }
        }

        public static DateTime ReadShortDate()
        {
            while (true)
            {
                PrintController.Execute("Введите число в формате dd.mm.yyyy");
                var input = ReadLine();
                var isParsed = DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result);

                if (isParsed)
                {
                    return result;
                }

                PrintController.Execute("Дата введена неверно");

            }
        }
    }
}

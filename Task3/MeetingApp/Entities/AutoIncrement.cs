using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp.Entities
{
    public class AutoIncrement
    {
        private static int id = 0;
        public static int GenerateId()
        {
            return id++;
        }
    }
}

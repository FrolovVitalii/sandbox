using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_3
{
    class ConsoleLogger : Ilogger
    {
        public void OutputTheLog(string text)
        {
            Console.WriteLine(text);
        }
    }
}

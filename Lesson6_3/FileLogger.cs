using System.Collections.Generic;
using System.IO;

namespace Lesson6_3
{
    class FileLogger : ILogger
    {
        List<string> logCollection = new List<string>();
        public void Log(string text)
        {
            logCollection.Add(text);
            string mydocpath = Directory.GetCurrentDirectory();
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", logCollection);
            logCollection.Clear();
        }
    }
}

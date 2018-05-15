#region Task3
/*
Create the interface ILogger with the method for outputting the text Log(string). Three implementation of the
interface: ConsoleLogger - Console output FileLogger -  output to file AggregateLogger - has the ILogger collection,
and when calling the Log method calls this method in each of the items in the collection.(Examples of output to a file
can be found here: https://msdn.microsoft.com/en-us/library/6ka1wd3w(v=vs.110).aspx) 
*/
#endregion
using System;
using System.Collections.Generic;


namespace Lesson6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ilogger> aggregateCollectionLoger = new List<Ilogger>();

            ConsoleLogger testConsoleLogger = new ConsoleLogger();
            testConsoleLogger.OutputTheLog("console log");
            aggregateCollectionLoger.Add(testConsoleLogger);


            FileLogger testFileLogger = new FileLogger();
            testFileLogger.OutputTheLog("create file log " + DateTime.Now.ToString());
            testFileLogger.OutputTheLog("create file log next time " + DateTime.Now.ToString());
            aggregateCollectionLoger.Add(testFileLogger);

            AggregateLogger aggregatelogger = new AggregateLogger(aggregateCollectionLoger);
            aggregatelogger.OutputTheLog("test aggregate log");
            aggregatelogger.OutputTheLog("test aggregate log 2");

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}

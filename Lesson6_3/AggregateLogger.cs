using System;
using System.Collections.Generic;


namespace Lesson6_3
{
    class AggregateLogger : Ilogger
    {
        private List<Ilogger> aggregateLogCollection;

        public AggregateLogger(List<Ilogger> loggers)
        {
            aggregateLogCollection = loggers;
        }

        public void OutputTheLog(string text)
        {

            {
                foreach (var item in aggregateLogCollection)
                {
                    item.OutputTheLog(text);
                }

            }
        }
    }
}

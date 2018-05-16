using System.Collections.Generic;


namespace Lesson6_3
{
    class AggregateLogger : ILogger
    {
        private List<ILogger> aggregateLogCollection = new List<ILogger>();

        public AggregateLogger(params ILogger[] loggers)
        {
            aggregateLogCollection = new List<ILogger>(loggers);
        }

        public void Log(string text)
        {

            {
                foreach (var item in aggregateLogCollection)
                {
                    item.Log(text);
                }

            }
        }
    }
}

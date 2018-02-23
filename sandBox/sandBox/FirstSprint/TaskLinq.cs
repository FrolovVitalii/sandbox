using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;


namespace FirstSprint
{
    // Description of User's class. 
    class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Surname { get; set; }

    }


    class CollectonOfObjectsTask
    {

        private List<Object> ItemCollection;

        public CollectonOfObjectsTask()
        {
            ItemCollection = new List<object>();
        }

        // Return Linq's result
        public List<User> TaskLinqResult(List<Object> CurrentCollection)
        {
            var result = (CurrentCollection
                                    .Where(r => r is User)
                                    .Cast<User>())
                                    .DistinctBy(i => i.Surname)
                                    .OrderByDescending(d => d.Id)
                                    .ToList<User>();

            return result;
        }
    }
    
}

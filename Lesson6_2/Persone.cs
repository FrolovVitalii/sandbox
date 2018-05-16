using System;
using System.Collections.Generic;
using System.Linq;


namespace Lesson6_2
{
    class Person : IHasId
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
            Id = name + age.ToString() + IdCreation();
        }

        public Person(string name, int age, string id)
        {
            Age = age;
            Name = name;
            this.Id = id;
        }

        private string IdCreation()
        {
            return DateTime.Now.ToString("yyyyHHmmss");
        }
    }
}

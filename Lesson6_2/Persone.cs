using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    class Persone : IHasId
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; }

        public Persone(string name, int age)
        {
            Age = age;
            Name = name;
            Id = name+age.ToString()+IdCreation();
        }

        private string IdCreation()
        {
            return DateTime.Now.ToString("yyyyHHmmss");
        }
    }
}

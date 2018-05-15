using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    class LegalPerson : IHasId
    {
        public string Id { get; }

        public LegalPerson()
        {
            Id = DateTime.Now.ToLongTimeString();
        }
    }
}

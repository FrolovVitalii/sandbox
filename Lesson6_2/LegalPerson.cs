using System;


namespace Lesson6_2
{
    class LegalPerson : IHasId
    {
        public string Id { get; }

        public LegalPerson()
        {
            Id = DateTime.Now.ToLongTimeString();
        }

        public LegalPerson(string id)
        {
            this.Id = id;
        }
    }
}

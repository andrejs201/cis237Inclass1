using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class PersonCollection
    {
        private Person[] personArray;
        private int lengthOfArray;

        public PersonCollection()
        {
            personArray = new Person[4];
            lengthOfArray = 0;
        }

        public void AddPerson(Person person)
        {
            personArray[lengthOfArray] = person;
            lengthOfArray++;
        }

        public string GetPersonCollectionToString()
        { 
            string fullOutput = "";
            foreach (Person person in personArray)
            {
                if (person != null)
                    fullOutput += person.ToString() + Environment.NewLine;
            }
            return fullOutput;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Andrejs", "Tomsons", 23);
            Person person2 = new Person("Joe", "Somebody", 85);

            person.PrintFullName();
            person2.PrintFullName();
            person.PrintFullName();

            PersonCollection personCollection = new PersonCollection();

            personCollection.AddPerson(person);
            personCollection.AddPerson(new Person("Not", "Declared First", 34));

            Console.WriteLine(personCollection.GetPersonCollectionToString());

            Console.WriteLine("Different things");
            Console.WriteLine("More Different things");
        }
    }
}

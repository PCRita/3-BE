using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_InterfacePerson_v2
{

    class Program
    {

        static void Main(string[] args)
        {
            Employee employee01 = new Employee();
            EffectiveEmployee effectiveEmployee01 = new EffectiveEmployee();
            Itern itern01 = new Itern();
            Client client01 = new Client();

            Console.WriteLine(employee01.AddNewPerson(""));
            Console.WriteLine(employee01.ListFullName(""));
            Console.WriteLine(employee01.EditAddress(""));
            Console.WriteLine(employee01.ListAddress(""));

            Console.WriteLine(effectiveEmployee01.ListWorkedHours(""));
            Console.WriteLine(effectiveEmployee01.ListVancacies(""));

            Console.WriteLine(itern01.ListIntershipHours(""));

            Console.WriteLine(client01.AddNewPerson(""));
            Console.WriteLine(client01.ListFullName(""));
            Console.WriteLine(client01.EditAddress(""));
            Console.WriteLine(client01.ListAddress(""));
            Console.WriteLine(client01.ListBirthday(""));

            Console.ReadKey();
        }
    }
}

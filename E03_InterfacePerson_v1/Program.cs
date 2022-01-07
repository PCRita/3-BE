using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_InterfacePerson_v1
{

    class Program
    {

        static void Main(string[] args)
        {
            Employee employee01 = new Employee();
            Itern itern01 = new Itern();
            Client client01 = new Client();

            Console.WriteLine(employee01.AddNewPerson(""));
            Console.WriteLine(employee01.ListFullName(""));
            Console.WriteLine(employee01.EditAddress(""));
            Console.WriteLine(employee01.ListAddress(""));
            Console.WriteLine(employee01.ListWorkedHours(""));
            Console.WriteLine(employee01.ListVancacies(""));

            Console.WriteLine(itern01.AddNewPerson(""));
            Console.WriteLine(itern01.ListFullName(""));
            Console.WriteLine(itern01.EditAddress(""));
            Console.WriteLine(itern01.ListAddress(""));
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

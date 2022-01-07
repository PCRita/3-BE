using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_InterfacePerson_v1
{
    class Employee : IPerson
    {
        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string WorkedHours { get; set; }
        public string Vacancies { get; set; }
        #endregion

        #region Methods
        public string AddNewPerson(string newPerson)
        {
            FullName = newPerson;
            Console.Write("Em construcao");
            return FullName;
        }

        public string ListFullName(string fullName)
        {
            Console.WriteLine($"O nome completo e {Name} {Surname} ");
            return FullName;
        }

        public string EditAddress(string editedAddress)
        {
            Address = editedAddress;
            Console.Write("Em construcao");
            return Address;
        }

        public string ListAddress(string address)
        {
            Address = address;
            Console.WriteLine($"A morada e {Address}.");
            return Address;
        }

        public string ListWorkedHours(string workedhours)
        {
            WorkedHours = workedhours;
            Console.WriteLine($"O funcionario trabalhou {WorkedHours} horas. ");
            return WorkedHours;
        }

        public string ListVancacies(string vacancies)
        {
            Vacancies = vacancies;
            Console.WriteLine($"O funcionario tem direito {Vacancies}. ");
            return Vacancies;
        }
        #endregion
    }

}

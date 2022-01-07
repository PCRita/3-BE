using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_InterfacePerson_v2
{

    class Client: IPerson
    {

        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Birthday { get; set; }
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

        public string ListBirthday(string birthday)
        {
            Birthday = birthday;
            Console.WriteLine($"o cliente faz anos em {Birthday} . ");
            return Birthday;
        }
        #endregion
    }

}

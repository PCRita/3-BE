using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_InterfacePerson_v1
{

    interface IPerson
    {
        #region Properties
        string Name { get; }
        string Surname { get; }
        string FullName { get; }
        string Address { get; }
        string Location { get; }
        #endregion

        #region Methods
        string AddNewPerson(string newPerson);
        string ListFullName(string fullName);
        string EditAddress(string editedAddress);
        string ListAddress(string address);

        #endregion
    }

}

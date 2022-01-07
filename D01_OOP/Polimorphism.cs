using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{

    class Polimorphism
    {
        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Location { get; set; }
        #endregion

        //overloading de metodos
        //method overloading== sobrecarga de metodos-->mesmo metodo com assinaturas diferentes
        #region Methods
        public void ListFullName()
        {
            Console.WriteLine($"Full name: {Name} {Surname}");
        }

        public void ListFullName(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine($"Full name: {Name} {Surname}");
        }

        public void ListFullNameUS(string surname, string name)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine($"Full name: {Surname}, {Name}");
        }

        //Marcar o metodo para overloading com virtual(classe base)
        public virtual void ListALL(string name, string surname, string location)
        {
            Name = name;
            Surname = surname;
            Location = location;

            Console.WriteLine($"{Name} {Surname} mora em {Location}.");
        }
        #endregion
    }

    class PolimorphismDerived : Polimorphism
    {

        //Overridingde metodos
        //method override= sobrescrita de metodos-->metodos com a mesma assinatura, mas diferentes implementacoes
        #region Methods
        //marcar o metodo para overloading com overrride(classe derivada)->senao  escondia a classe base
        public override void ListALL(string name, string surname, string location)
        {
            Name = name;
            Surname = surname;
            Location = location;

            Console.WriteLine($"{Surname}, {Name} lives in {Location}.");
        }
        #endregion
    }
}

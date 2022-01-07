using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{

    class Program
    {

        static void Main(string[] args)
        {
            #region Inheritance
            /*
            #region Create objects
            Person person01 = new Person();
            Person person02 = new Person("m", "rs");
            Student student01 = new Student();
            Student student02 = new Student("a", "rp");
            Student student03 = new Student("am", "rprs", "be", "e");
            #endregion

            #region Call methods
            person02.ListFullName();
            student03.ListAll();
            
            #endregion
            */
            #endregion

            #region Encapsulation
            /*
            Encapsulation encapsulation01 = new Encapsulation();

            encapsulation01.Name = "m";
            encapsulation01.Surname = "rs";
            encapsulation01.List01();

            //quick info list ctrl spacebar
            */
            #endregion

            #region Polymorphism
            /*
            Polimorphism baseClass01 = new Polimorphism();
            PolimorphismDerived derivedClass01 = new PolimorphismDerived();
                        
            baseClass01.ListFullName();
            baseClass01.ListFullName("m", "rs");
            baseClass01.ListFullNameUS("rs", "m");
            baseClass01.ListALL("m", "rs", "e");
            derivedClass01.ListALL("m", "rs", "e");
            */
            #endregion

            #region Abstractrion
            //AbstractAnimal abstractAnimal01 = new AbstractAnimal();--> não se pode fazer, dá erro, pq a classe é abstracta nao pode ser instanciada!

            VertebrateAnimal vertebrateAnimal = new VertebrateAnimal();
            UnvertebrateAnimal unvertebrateAnimal = new UnvertebrateAnimal();

            vertebrateAnimal.Register();
            vertebrateAnimal.List("Gato");

            unvertebrateAnimal.Register();
            unvertebrateAnimal.List("Polvo");
            #endregion

            Console.ReadKey();
        }

    }

}

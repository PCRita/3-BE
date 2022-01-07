using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    /*abstract class Normal
    {
        public abstract int V1 { get; set; }
        public abstract int V2 { get; set; }
        public abstract int Result { get; set; }

        public abstract void List();
       
    }

    class DerivadaNormal : Normal
    {
        public int V1 { get; set; }
        public int V2 { get; set; }
        public int V3 { get; set; }

        public void Calculate()
        { }
    }*/

    //Class abstrata:
    //      nao pode ser instanciada
    //      tem de ser herdada para se poder trabalhar com ela
    //      todos os membros abstratos tem de ser implementados-->{}
    //      pode ter membros abstract e nao abstract(ex. properties, methods)

    abstract class AbstractAnimal
    {
        #region Properties
        public abstract string Name { get; set; }
        public string Color { get; set; }
        public abstract bool Pet { get; set; }
        #endregion

        #region Methods
        //Um metodo abstrato nao pode ser implementado na classe abstrata
        //Tem de ser implemenetado na classse derivada com override e com a mesma assinatura-> ()
        public void Register()
        {
            Console.WriteLine($"\nA registar o animal:\n");
        }

        public abstract void List(string name);

        public abstract void Domesticate();

        #endregion
    }

    class VertebrateAnimal : AbstractAnimal
    {
        #region Constants
        public const string TYPE = "Vertebrate";
        #endregion

        #region Properties
        public override string Name { get; set; }

        public override bool Pet { get ; set ; }
        #endregion
       
        #region Methods
        public override void Domesticate()
        {
            Pet = true;
        }

        public override void List(string name)
        {
            Name = name;

            Console.Write($"Animal: {Name} ({TYPE}).\n");
        } 
        #endregion

    }

    class UnvertebrateAnimal : AbstractAnimal
    {

        #region Constant
        public const string TYPE = "Unvertebrate";
        #endregion

        #region Properties
        public override string Name { get ; set ; }
        public override bool Pet { get ; set ; }
        #endregion

        #region Methods
        public override void Domesticate()
        {
            Pet = false; 
        }

        public override void List(string name)
        {
            Name = name;

            Console.WriteLine($"Animal: {Name} ({TYPE})");
        }
        #endregion
        

       
    }

}

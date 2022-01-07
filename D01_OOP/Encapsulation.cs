using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{

    //Access modifiers: public, private(controla ao que podemos aceder)
    //Por defeito as classes sao public--> podem ser usadas noutras classes

    //Encapsulation:
    //      propriedade+metodos:public
    //      variaveis+fields:private
    class Encapsulation
    {
        //declaracao de uma variavel
        
        #region Variaveis (publicas a classse, privadas fora da classe)
        /*
        private int value01 = 0;
        */
        #endregion
        
        #region Field(variavel de suporte a propriedade)
        private string name;
        #endregion
        
        #region Properties
        //Classic: como se fazia no inicio, requer um field privado onde se declara a variavel de suporte, neste caso name=>já nao se usa
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        
        //auto-implemented
        public string Surname { get; set; }

        //Bodied-expression(lambda operator =>)
        #endregion

        #region Methods
        public void List01()
        {
            // Surname = "fgt";            //set é para escrever o valor da propriedade
            //Console.WriteLine(Surname);//get é para ler o valor da propriedade

            Console.WriteLine($"{Name} {Surname}");
        }

        //Por omissaodo access modifier, o metodo e private(so pode ser usado dentro da classe)
        //No entanto, o metodo devia ser public
        void List02()
        {

        }

        #endregion

    }

}

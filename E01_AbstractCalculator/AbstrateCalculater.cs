using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_AbstractCalculator
{

    abstract class AbstrateCalculater
    {
        #region Properties
        
        public abstract double Valor1 { get; set; }
        public abstract double Valor2 { get; set; }
        public abstract string Operacao { get; set; }
        public abstract double Resultado { get; set; }
        #endregion

        #region Methods
        public abstract double Somar(double V1,double V2);
        public abstract double Subtrair(double V1, double V2);
        public abstract double Multiplicar(double V1, double V2);
        public abstract double Dividir(double V1, double V2);
        #endregion

        
    }

}

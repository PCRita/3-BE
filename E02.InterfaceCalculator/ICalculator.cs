using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_InterfaceCalculator
{

    interface ICalculator
    {
        #region Properties
        double Valor1 { get; }
        double Valor2 { get; }
        string Operacao { get; }
        double Resultado { get; }
        #endregion

        #region Methods 
        double Somar(double v1, double v2);
        double Subtrair(double v1, double v2);
        double Multiplicar(double v1, double v2);
        double Dividir(double v1, double v2);
        #endregion
    }

}

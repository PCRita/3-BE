using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_InterfaceCalculator
{

    class ScientificCalculator : ICalculator
    {
        #region Properties
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public string Operacao { get; set; }
        public double Resultado { get; set; }
        #endregion

        #region Methods

        public double Dividir(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 / v2;
            return Resultado;
        }

        public double Multiplicar(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 * v2;
            return Resultado;
        }

        public double Somar(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 + v2;
            return Resultado;
        }

        public double Subtrair(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 - v2;
            return Resultado;
        }

        public double RaizQuadrada(double v1)
        {
            Valor1 = v1;
            Resultado = Math.Sqrt(Valor1);
            return Resultado;
        }

        public double ValorAbsoluto(double v1)
        {
            Valor1 = v1;
            Resultado = Math.Abs(Valor1);
            return Resultado;
        }
        #endregion

    }

}

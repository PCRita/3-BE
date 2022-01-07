using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_AbstractCalculator
{
    class SimpleCalculator : AbstrateCalculater
    {
        #region Properties
        public override double Valor1 { get; set; }
        public override double Valor2 { get; set; }
        public double Valor3 { get; set; }
        public double Valor4 { get; set; }
        public override string Operacao { get; set; }
        public override double Resultado { get; set; }
        #endregion

        #region Methods
        public override double Dividir(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 / v2;
            return Resultado;
        }

        public override double Multiplicar(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 * v2;
            return Resultado;
        }

        public double Multiplicar(double v1, double v2, double v3)
        {
            Valor1 = v1;
            Valor2 = v2;
            Valor3 = v3;
            Resultado = v1 * v2 * v3;
            return Resultado;
        }

        public double Multiplicar(double v1, double v2, double v3, double v4)
        {
            Valor1 = v1;
            Valor2 = v2;
            Valor3 = v3;
            Valor4 = v4;
            Resultado = v1 * v2 * v3 * v4;
            return Resultado;
        }

        public override double Somar(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 + v2;
            return Resultado;
        }

        public double Somar(double v1, double v2, double v3)
        {
            Valor1 = v1;
            Valor2 = v2;
            Valor3 = v3;
            Resultado = v1 + v2 + v3;
            return Resultado;
        }

        public override double Subtrair(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 - v2;
            return Resultado;
        }

        #endregion

    }
}

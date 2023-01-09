using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Tipos_Estruturas_Repeticao_Salario
{
    public static class Salario
    {
        public static double CalculaReajuste(double salario)
        {
            if (salario <= 300)
                return salario * 0.5 + salario;
            if (salario > 300)
                return salario * 0.3 + salario;

            return salario;
        }
    }
}

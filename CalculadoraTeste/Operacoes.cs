using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcTeste
{
    public static class Operacoes
    {
        public static double ImcConta(double peso, double altura)
        {
            return Math.Round(peso/(altura * altura),2);
        }
        public static string ImcResultado(double resultado)
        {
            if (resultado < 18.5)
            {
                return "Magreza";
            }
            else if (resultado < 25)
            {
                return "Normal";
            }
            else if (resultado < 30)
            {
                return "Sobrepeso";
            }
            else if (resultado < 40)
            {
                return "Obesidade";
            }
            else
            {
                return "Obesidade grave";
            }

        }   
    }
}

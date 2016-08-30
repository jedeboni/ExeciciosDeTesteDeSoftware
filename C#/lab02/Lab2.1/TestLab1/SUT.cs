using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab1
{
    class SUT
    {
        //   
        // 
        //
        public String Triangulos(double a, double b, double c)
        {
            String Tipo = "escaleno";
            if ((a == b) && (a == c)) { return ("equilátero"); };
            if ((a == c) || (b == c)) { return ("isóceles"); };
            return Tipo;
        }

        public String Triangulos2(double a, double b, double c)
        {
            String Tipo = "ERRO";
            // Método corrigido com as validações das classes de equivalência
            //
            // verifica se algum é zero ou negativo
            if ((a <= 0) || (b <= 0) || (c <= 0)) return Tipo;
            //
            // verificar se é Triangulo
            double Maior = a;
            double SomaMenor = b + c;
            if (b > Maior) { Maior = b; SomaMenor = a + c; };
            if (c > Maior) { Maior = c; SomaMenor = a + b; };
            if (Maior >= SomaMenor) {return Tipo;};
            //
            // Se é um triângulo,  analisa o tipo

            if ((a != b) && (a != c) && (b != c)) { return ("escaleno"); };
            if ((a == b) && (a == c)) { return ("equilátero"); };
            if ((a == c) || (b == c) || (b==c)) { return ("isóceles"); };
            return Tipo; 
        }

    }
}

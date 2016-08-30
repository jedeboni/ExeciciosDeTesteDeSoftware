using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Imposto2016
    {
        public double calcula(double Base)
        {
            /*
            *  Imposto de Renda Anual
            *  Até 21453,24 - isento
            *  de 21453,25 até 32151,48  Aliquota  7,5% Desc. 1608,99
            *  de 32151,49 até 42869,16  Aliquota 15,0% Desc. 4020,35
            *  de 42869,17 até 53565,72  Alíquota 22,5% Desc. 7235,54
            *  acima 53565,72            Alíquota 27,5% Desc. 9913,83
            */
            Double Imposto = 0.0;

            if (Base < 21453.24)
            {
                Imposto = 0.0;
            }
            if ((Base >= 21453.25) && (Base <= 32151.48))
            {
                Imposto = Base * 0.075 - 1608.99;
            }
            if ((Base >= 32151.49) && (Base <= 42869.16))
            {
                Imposto = Base * 0.15 - 4020.35;
            }
            if ((Base >= 42869.17) && (Base <= 53565.72))
            {
                Imposto = Base * 0.225 - 7235.54;
            }
            if (Base >= 53565.72)
            {
                Imposto = Base * 0.275 - 9913.83;
            }
            return Imposto;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Imposto2010
    {
        public double calculo(double _base)
        {
            double _valor = 0.0;
            if (_base <= 1434.59)
            {
                _valor = 0.0;
            }
            if ((_base > 1434.60) && (_base<= 2150.00)){
                _valor = _base * 0.075 - 107.59;
            }
            if ((_base >= 2150.01) && (_base <= 2866.70)){
                _valor = _base * 0.15 - 268.84;
            }
            if ((_base >= 2866.70) && (_base <= 3582.00)){
                _valor = _base * 0.075 - 107.59;
            }
            if ((_base >= 3582.00)){
                _valor = _base * 0.075 - 107.59;
            }
            return _valor;
        }
    }
}

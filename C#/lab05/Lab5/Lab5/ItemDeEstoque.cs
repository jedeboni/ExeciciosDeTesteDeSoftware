using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    public class ItemDeEstoque
    {
        public int loteReposicao = 100;
        public int estoqueMinimo = 50;
        public int qtd = 100;
        public String codigo = "10101 Tonner Impressora";
    
        public String ReporMaterial (int _qt)
        {
            qtd = qtd + loteReposicao;
            return "Material Reposto";
        }

        public String RetirarMaterial (int _qt)
        {
            if (estoqueBaixo())
            {
                return "Estoque Baixo";
            } else
            {
                if (qtd > _qt)
                {
                    qtd = qtd - _qt;
                    return "";
                } else
                {

                    return "Estoque insuficiente \n NECESSIDADE DE COMPRA";
                }

            }

        }

        public string toString()
        {
            String saida = "\n" + codigo;
            saida = saida + "\n\t Quantidade = " + qtd;
            saida = saida + "\n\t Minimo     = " + estoqueMinimo;
            saida = saida + "\n\t Reposicao  = " + loteReposicao;
            saida = saida + "\n";
            return saida;
        }

        private Boolean estoqueBaixo()
        {
            return (this.qtd <= estoqueMinimo);
        }
            
     }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Triangulo
{
    class Funcionario
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionaProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RetirarProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }
}

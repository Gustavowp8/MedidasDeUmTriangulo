using System;
using System.Globalization;
using System.Threading;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programas e atividades em c#");
            Thread.Sleep(1600);
            Menu();

        }
        static void Menu()
        {
            Console.WriteLine("====== Opções ======");
            Console.WriteLine(" ");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Lados de um triangulo");
            Console.WriteLine("2 - Cadstro de funcionario");
            Console.WriteLine("3 - Cadastro de produtos");
            Console.WriteLine("4 - Imposto no salario");

            Console.WriteLine(" ");
            Console.Write("Digite o numero da opção: ");

            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 0: Sair(); break;
                case 1: LadoTriangulo(); break;
                case 2: Cadastro(); break;
                case 3: Produtos(); break;
                case 4: Imposto(); break;
            }
        } 
        static void LadoTriangulo()
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("A Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("A maior area e do triangulo X");
            }
            else
            {
                Console.WriteLine("A maior area e do triagulo Y");
            }
        }
        static void Cadastro()
        {
            Console.Clear();

            Console.WriteLine("Dados de pessoas");
            Console.WriteLine(" ");

            Pessoas nome, salario, segundonome, segundosalario;

            nome = new Pessoas();
            salario = new Pessoas();
            segundonome = new Pessoas();
            segundosalario = new Pessoas();

            Console.Write("Digite um nome: ");
            nome.N = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Valor do salario: ");
            salario.S = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Digite um nome: ");
            segundonome.N = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Valor do salario: ");
            segundosalario.S = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if(salario.S > segundosalario.S)
            {
                Console.WriteLine($"O salario de {nome.N} e maior");
            } else
            {
                Console.WriteLine($"O salario de {segundonome.N} e maior");
            }


            Console.ReadKey();
            Sair();
        }

        static void Produtos()
        {
            Funcionario p = new Funcionario();

            Console.WriteLine("Cadastro de produtos");
            Console.WriteLine(" ");

            Console.WriteLine("Digite os dados do produto");
            Console.WriteLine("================");

            Console.Write("Nome Produto: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" ");

            Console.Write("Digite a quantidade deste produto: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Dados do produto: "+ p);

            Console.WriteLine(" ");
            Console.Write("Digite uma quantidade de produtos para ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionaProdutos(qte);
            Console.WriteLine(" ");
            Console.WriteLine("Dados atualizado: "+ p);

            Console.WriteLine(" ");

            Console.WriteLine("Digite a quantidade de produtos para ser removido: ");
            int menosqte = int.Parse(Console.ReadLine());
            p.RetirarProduto(menosqte);
            Console.WriteLine(" ");
            Console.WriteLine("Dados atualizado: " + p);
        }

        static void Imposto()
        {
            Console.Clear();
            Thread.Sleep(1600);
            Console.WriteLine("Aumento de Salario");
            Console.WriteLine(" ");

            Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);



        }
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigado");
        }
    }
}

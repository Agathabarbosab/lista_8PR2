using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista8_PR2provisoria
{
    internal class Program

    {
        public static void Exercicio1()
        {
            Console.WriteLine("Exercicio1=");
            int i = 1;
            do
            {


                float valorproduto = 1, quantidadeitens = 1, valortotal = 0, totaldprodutos = 0;
                int d = 1;
                do
                {
                    quantidadeitens++;
                    Console.WriteLine("Digite a quantidade de itens:");
                    quantidadeitens = float.Parse(Console.ReadLine());
                    if (quantidadeitens == 0)
                        break;
                    valorproduto++;
                    Console.WriteLine("digite o valor do produto");
                    valorproduto = float.Parse(Console.ReadLine());
                    if (valorproduto == 0)
                        break;

                    totaldprodutos += quantidadeitens;
                    valortotal += quantidadeitens * valorproduto;
                    Console.WriteLine("O valor total da sua compra é de:" + valortotal);
                    Console.WriteLine("A Quantidade de itens total da sua compra é de:" + totaldprodutos);

                } while (true);




            } while (i != 0);



        }
        public static void Exercicio2()
        {
            Console.WriteLine("Exercicio2=");
            int o = 1;
            do
            {
                int itens, cparada = 2;
                float preco, ma, me, total;
                string nomep, nomema = "", nomeme = "";

                ma = float.MaxValue;
                me = float.MinValue;

                do
                {
                    Console.WriteLine("Digite o nome do produto:");
                    nomep = Console.ReadLine();

                    Console.WriteLine("Digite a quantidade total de itens:");
                    itens = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor unitario deste produto:");
                    preco = float.Parse(Console.ReadLine());

                    total = itens * preco;
                    if (total > itens)
                    {
                        ma = total;
                        nomema = nomep;
                    }

                    if (total < me)
                    {
                        me = total;
                        nomeme = nomep;
                    }

                    Console.WriteLine("digite 2 se desejar continuar ou 1 se deseja sair:");
                    cparada = int.Parse(Console.ReadLine());
                    Console.WriteLine("Maior investimento {0} no produto {1}", ma, nomema);
                    Console.WriteLine("Menor investimento {0} no produto {1}", me, nomeme);
                    Console.WriteLine("Para executar novamente digite 1, e 0 se desejs parar:");
                    o = int.Parse(Console.ReadLine());






                } while (cparada != 0);


            } while (o != 0);


        }
        public static void Exercicio3()
        {
            Console.WriteLine("Exercicio3=");
            float pesostotais = 0, p;
            int qavaliacoes;
            Console.WriteLine("Quantas avaliações serão aplicadas:");
            qavaliacoes = int.Parse(Console.ReadLine());

            int u = 0;
            do
            {
                u++;
                Console.WriteLine("Peso das notas {1}");
                p = float.Parse(Console.ReadLine());
                pesostotais += p;
            } while (u < qavaliacoes);

            Console.WriteLine("Soma de pesos:" + pesostotais);
            if (pesostotais < 100)

                Console.WriteLine("Peso necessario não atingido.");

            else if (pesostotais > 100)
                Console.WriteLine("Peso necessario exedido.");

            else
                Console.WriteLine("Porcentagem necessaria atingida.");



        }
        public static void Exercicio4()
        {
            Console.WriteLine("Exercicio4=");
            int a = 1;
            do
            {
                string sigla;
                Console.WriteLine("informe a sigla do estado desejado utilizando letras maiusculas:");
                sigla = Console.ReadLine();

                switch (sigla)
                {
                    case "AC":
                        Console.WriteLine("sigla referente ao Acre");
                        break;

                    case "AL":
                        Console.WriteLine("sigla referente ao Alagoas");
                        break;
                    case "AP":
                        Console.WriteLine("sigla referente ao Amapá");
                        break;
                    case "AM":
                        Console.WriteLine("sigla referente ao Amazonas");
                        break;
                    case "BA":
                        Console.WriteLine("sigla referente ao Bahia");
                        break;
                    case "CE":
                        Console.WriteLine("sigla referente ao Ceará");
                        break;
                    case "DF":
                        Console.WriteLine("sigla referente ao Distrito Federal");
                        break;
                    case "ES":
                        Console.WriteLine("sigla referente ao Espirito Santo");
                        break;
                    case "GO":
                        Console.WriteLine("sigla referente ao Goiás");
                        break;
                    case "MA":
                        Console.WriteLine("sigla referente ao Maranhão");
                        break;
                    case "MT":
                        Console.WriteLine("sigla referente ao Mato Grosso");
                        break;
                    case "MS":
                        Console.WriteLine("sigla referente ao Mato Grosso do Sul");
                        break;
                    case "MG":
                        Console.WriteLine("sigla referente ao Minas Gerais");
                        break;
                    case "PA":
                        Console.WriteLine("sigla referente ao Pará");
                        break;
                    case "PB":
                        Console.WriteLine("sigla referente ao Paraíba");
                        break;
                    case "PR":
                        Console.WriteLine("sigla referente ao Paraná");
                        break;
                    case "PE":
                        Console.WriteLine("sigla referente ao Pernambuco");
                        break;
                    case "PI":
                        Console.WriteLine("sigla referente ao Piauí");
                        break;
                    case "Rj":
                        Console.WriteLine("sigla referente ao Rio de Janeiro");
                        break;
                    case "RN":
                        Console.WriteLine("sigla referente ao Rio Grande do Norte");
                        break;
                    case "RS":
                        Console.WriteLine("sigla referente ao Rio Grande do Sul");
                        break;
                    case "RO":
                        Console.WriteLine("sigla referente ao Rondonia");
                        break;
                    case "RR":
                        Console.WriteLine("sigla referente ao Roraima");
                        break;
                    case "SC":
                        Console.WriteLine("sigla referente ao Santa Catarina");
                        break;
                    case "SP":
                        Console.WriteLine("sigla referente ao São Paulo");
                        break;
                    case "SE":
                        Console.WriteLine("sigla referente ao Sergipe");
                        break;
                    case "TO":
                        Console.WriteLine("sigla referente ao Tocantins");
                        break;
                    default:
                        Console.WriteLine("Sigla invalida");
                        break;

                }

            } while (a != 0);


        }
        public static void Exercicio5()
        {
            Console.WriteLine("Exercicio5=");
            int b = 1;
            do
            {
                int mes, dia;

                Console.WriteLine("Digite o numero que representa um mes do ano:");
                mes = int.Parse(Console.ReadLine());
                switch (mes)
                {
                    case (1):
                        Console.WriteLine("verão");
                        break;
                    case (2):
                        Console.WriteLine("verão");
                        break;
                    case (3):
                        Console.WriteLine("Digite o dia:");
                        dia = int.Parse(Console.ReadLine());
                        if (dia >= 20)
                            Console.WriteLine("outono");
                        else
                            Console.WriteLine("verão");
                        break;
                    case (4):
                        Console.WriteLine("outono");
                        break;
                    case (5):
                        Console.WriteLine("outono");
                        break;
                    case (6):
                        Console.WriteLine("Digite o dia:");
                        dia = int.Parse(Console.ReadLine());
                        if (dia >= 20)
                            Console.WriteLine("inverno");
                        else
                            Console.WriteLine("outono");
                        break;
                    case (7):
                        Console.WriteLine("inverno");
                        break;
                    case (8):
                        Console.WriteLine("inverno");
                        break;
                    case (9):
                        Console.WriteLine("me informe o dia:");
                        dia = int.Parse(Console.ReadLine());
                        if (dia >= 22)
                            Console.WriteLine("primavera");
                        else
                            Console.WriteLine("inverno");
                        break;
                    case (10):
                        Console.WriteLine("primavera");
                        break;
                    case (11):
                        Console.WriteLine("primavera");
                        break;
                    case (12):
                        Console.WriteLine("me informe o dia:");
                        dia = int.Parse(Console.ReadLine());
                        if (dia >= 21)
                            Console.WriteLine("verão");
                        else
                            Console.WriteLine("primavera");
                        break;
                }
            } while (b != 0);




        }
        public static void Exercicio6()
        {
            Console.WriteLine("Exercicio6=");
            int g = 1;
            do
            {
                Console.WriteLine("Informe o seu peso:");
                float peso = float.Parse(Console.ReadLine());


                Console.WriteLine("Informe sua altura:");
                float altura = float.Parse(Console.ReadLine());

                float imc = peso / (altura * altura);

                if (imc < 18.5)
                {

                    Console.WriteLine("Abaixo do peso.");
                }
                else if (imc == 18.5 && imc == 24.9)
                {
                    Console.WriteLine("Peso normal.");

                }
                else if (imc == 25 && imc == 29.9)
                {
                    Console.WriteLine("Sobre peso.");
                }
                else if (imc == 30.0 && imc == 34.9)
                {
                    Console.WriteLine("Obesidade grau 1.");
                }
                else if (imc == 35 && imc == 39.9)
                {
                    Console.WriteLine("Obesidade grau 2.");
                }
                else
                {
                    Console.WriteLine("Obesidade grau 3.");
                }


                Console.WriteLine("digite 2 se desejar continuar ou 1 se deseja sair:");
                int para = int.Parse(Console.ReadLine());

            } while (g != 0);

        }
        public static void Exercicio7()
        {
            Console.WriteLine("Exercicio7=");
            int v = 1;
            do
            {
                Console.WriteLine("Digite um numero:");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Divisores de " + numero + ":");

                int fn = 0;
                while (fn <= numero)
                {
                    fn++;
                    if (numero % fn == 0)
                    {
                        Console.WriteLine(fn);
                    }
                }



            } while (v != 0);
        }
        static void Main(string[] args)
        {

            int exercicio;
            do
            {
                Console.WriteLine("======Menu======");
                Console.WriteLine("exercicio 1 - Digite1");
                Console.WriteLine("exercicio 2 - Digite2");
                Console.WriteLine("exercicio 3 - Digite3");
                Console.WriteLine("exercicio 4 - Digite4");
                Console.WriteLine("exercicio 5 _ Digite5");
                Console.WriteLine("exercicio 6 - Digite6");
                Console.WriteLine("exercicio 7 - Digite7");
                Console.WriteLine("Digite 0 - caso queira sair:");

                exercicio = int.Parse(Console.ReadLine());

                switch (exercicio)
                {
                    case 0:
                        Console.WriteLine("Obrigada por utilizar este programa!!!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;
                    case 7:
                        Exercicio7();
                        break;

                    default:
                        Console.WriteLine("Opção invalida:");
                        break;
                }
            } while (exercicio != 0);


        }
    }
}

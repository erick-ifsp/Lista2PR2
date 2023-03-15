using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1

            //double tl, l;

            //Console.WriteLine("escreva o numero de laranjas compradas na loja do Seu Marqueolítico: ");
            //tl = double.Parse(Console.ReadLine());

            //if (tl > 12)
            //{
            //    l = tl * 0.28;
            //    Console.WriteLine("O total de laranjas em reais foi de: R$" + l);
            //}

            //else
            //{
            //    l = tl * 0.35;
            //    Console.WriteLine("O total de laranjas em reais foi de: R$" + l);
            //}

            //exercicio 2

            //int ano, idade;

            //Console.WriteLine("escreva o ano em que voce nasceu:");
            //ano = int.Parse(Console.ReadLine());
            //idade = 2026 - ano;

            //if (idade < 16)
            //{
            //    Console.WriteLine("você não poderá votar nas proximas eleições");
            //}
            //else
            //{
            //    Console.WriteLine("você poderá votar nas proximas eleições");
            //}

            //exercicio 3

            //double a, b, c;

            //Console.WriteLine("digite um valor para A: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite um valor para B: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite um valor para C: ");
            //c = double.Parse(Console.ReadLine());

            //if (a == b && b == c)
            //{
            //    Console.WriteLine("o triangulo é equilatero.");
            //}
            //else if (a == b && b != c || a != b && b == c)
            //{
            //    Console.WriteLine("o triangulo é isosceles.");
            //}
            //else
            //{
            //    Console.WriteLine("o triangulo é escaleno.");
            //}

            //exercicio 4

            //double a, b, c, d, r, rm;

            //Console.WriteLine("digite um valor para A: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite um valor para B: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite um valor para C: ");
            //c = double.Parse(Console.ReadLine());

            //d = (b * b) - 4 * a * c;
            //r = (b * -1) + (d / d) / 2 * a;
            //rm = (b) - (d / d) / 2 * a;

            //Console.WriteLine("as raizes podem ser: " + r + " ou " + rm);

            //exercicio 5

            //int n;

            //Console.WriteLine("digite um numero: ");
            //n = int.Parse(Console.ReadLine());

            //if (n % 3 == 0)
            //{
            //    Console.WriteLine("O numero é divisivel por 3");
            //}

            //else
            //{
            //    Console.WriteLine("O numero não é divisivel por 3");
            //}

            //if (n % 5 == 0)
            //{
            //    Console.WriteLine("O numero é divisivel por 5");
            //}

            //else
            //{
            //    Console.WriteLine("O numero não é divisivel por 5");
            //}

            //exercicio 6

            //int a, b, c;

            //Console.WriteLine("digite um valor para A: ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite um valor para B: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite um valor para C: ");
            //c = int.Parse(Console.ReadLine());

            //if (a == 90 || b == 90 || c == 90)
            //{
            //    Console.WriteLine("o triangulo possui um angulo reto.");
            //}
            //else if (a > 90 || b > 90 || c > 90)
            //{
            //    Console.WriteLine("o triangulo possui um angulo obtuso.");
            //}
            //else if (a < 90 && b < 90 && c < 90)
            //{
            //    Console.WriteLine("o triangulo é acutangulo.");
            //}

            //exercicio 7

            //int a, b, c;

            //Console.WriteLine("qual o valor do numero ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do numero ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do numero ");
            //c = int.Parse(Console.ReadLine());

            //if (a < b && b < c) 
            //Console.WriteLine(a + "" + b + "" + c);
            //else if (a < b  && b > c)
            //Console.WriteLine(a + "" + c + "" + b);
            //else if (b < a  && a < c)
            //Console.WriteLine(b + "" + a + "" + c);
            //else if (b < a  && a > c)
            //Console.WriteLine(b + "" + c + "" + a);
            //else if (c < a  && a < b)
            //Console.WriteLine(c + "" + a + "" + b);
            //else if (c < a  && a > c)
            //Console.WriteLine(c + "" + b + "" + a);

            //exercicio 8

            //int ano;

            //Console.WriteLine("escreva um ano: ");
            //ano = int.Parse(Console.ReadLine());

            //if (ano % 4 == 0)
            //{
            //    Console.WriteLine("O ano é bissexto");
            //}
            //else
            //{
            //    Console.WriteLine("O ano não é bissexto");
            //}

            //exercicio 9

            //double a, b, r;
            //char car;

            //Console.WriteLine("escreva um valor para A: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("escreva um valor para B: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("escreva uma operação: ");
            //car = char.Parse(Console.ReadLine());

            //if (car == '+')
            //{
            //    Console.WriteLine(a + b);
            //}
            //else if (car == '-')
            //{
            //    Console.WriteLine(a - b);
            //}
            //else if (car == '*')
            //{
            //    Console.WriteLine(a * b);
            //}
            //else if (car == '/')
            //{
            //    Console.WriteLine(a / b);
            //}

            //exercicio 10

            //Na linguagem C#, é possível gerar números aleatórios usando a classe Random. Esta classe permite gerar números inteiros e reais aleatórios usando diferentes métodos.
            //Para gerar números inteiros aleatórios em C#, basta criar uma instância da classe Random e chamar o método Next() da seguinte forma:

            //Random random = new Random();
            //int randomInt = random.Next();

            //Para gerar números reais aleatórios em C#, é possível usar o método NextDouble(), que retorna um número aleatório entre 0 e 1, Se quiser gerar um número aleatório dentro de um intervalo específico, basta multiplicar o resultado pelo tamanho do intervalo e somar o valor mínimo

            //Random random = new Random();
            //double randomDouble = Random.NextDouble();

            //Em ambos os casos, é importante criar uma única instância da classe Random e reutilizá-la para gerar números aleatórios diferentes. Isso porque, se você criar várias instâncias em rápida sucessão, elas podem gerar números semelhantes, tornando a distribuição menos aleatória.




        }
    }
}

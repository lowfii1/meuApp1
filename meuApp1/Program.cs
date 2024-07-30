using System;

namespace meuApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int i;
            Console.WriteLine("Digite um número para a tabuada");
            numero = int.Parse(Console.ReadLine());
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
        }
    }
}

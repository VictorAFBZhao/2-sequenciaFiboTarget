using System;

namespace TesteTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int soma = 0;
            int desejado=0;

            Console.WriteLine("digite um numero: ");
            desejado = int.Parse(Console.ReadLine());

            while(soma <= desejado)
            {
                soma = n1 + n2;
                n1 = n2;
                n2 = soma;
                Console.Write("{ ");
                Console.Write(soma);
                Console.Write(" }");
                Console.Write(" ---");
            }
          

            if( n1 == desejado)
            {
                Console.WriteLine("O numero escolhido pertence a sequencia. ");
            }
            else
            {
                Console.WriteLine("O numero escolhido nao pertence a sequencia. ");
            }
        }
    }
}

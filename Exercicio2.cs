using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos números da sequência de Fibonacci você deseja gerar? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sequência de Fibonacci:");

        // Inicializando os primeiros dois números da sequência
        Console.WriteLine("Digite o primeiro número");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        int b = Int32.Parse(Console.ReadLine());

        // Imprimindo os "n" primeiros números da sequência
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int temp = a;
            a = b;
            b = temp + b;
        }
    }
}

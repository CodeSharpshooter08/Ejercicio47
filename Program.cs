using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número entero Rama 1:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número entero:");
        int numero2 = int.Parse(Console.ReadLine());

        bool esParNumero1 = numero1 % 2 == 0;
        bool esParNumero2 = numero2 % 2 == 0;

        if (esParNumero1 != esParNumero2)
        {
            Console.WriteLine("Uno de los números es par.");
        }
        else
        {
            Console.WriteLine("Ambos números son pares o ambos son impares.");
        }
    }
}

using System;

class SumaSinOperador
{
    static void Main(string[] args)
    {
        int a;
        int b;
        int suma = 0;

        Console.WriteLine("escribe el primer numero: ");
        a=int.Parse(Console.ReadLine());
        Console.WriteLine("escribe el segundo numero: ");
        b=int.Parse(Console.ReadLine());


        for (int i = 0; i < a; i++)
        {
            suma++;
        }

        for (int i = 0; i < b; i++)
        {
            suma++;
        }

        Console.WriteLine("La suma de {0} y {1} es: {2}", a, b, suma);
    }
}



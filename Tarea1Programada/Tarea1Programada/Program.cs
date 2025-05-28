using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hola, Escribe tu nombre: ");
        string name1 = Console.ReadLine();
        Console.Write("\nBienvenid@ " + name1 + "\n");
        Console.Write("Escriba un numero de 2 a 45:");
        string input = Console.ReadLine();
        int n;

        if (!int.TryParse(input, out n) || n < 2 || n > 45)
        {
            Console.WriteLine("El valor insertado esta fuera de rango");
            return;
        }

        double phi = (1 + Math.Sqrt(5)) / 2;
        Console.WriteLine();
        Console.WriteLine("Phi ~ " + phi);

        int[] fib = new int[n + 1];
        fib[0] = 0;
        fib[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }

        for (int i = 2; i <= n; i++)
        {
            double ratio = (double)fib[i] / fib[i - 1];
            double diff = Math.Abs(phi - ratio);
            Console.WriteLine("Fib({0}) / Fib({1}) ~ {2} [+- {3}]", i, i - 1, ratio, diff);
        }

        Console.WriteLine();
        Console.WriteLine("Fib({0}) = {1}", n, fib[n]);
        Console.WriteLine("Fib({0}) = {1}", n - 1, fib[n - 1]);
    }
}

//Ejecutar compilador
//cd C:\ProgramacionAvanzada\Tarea1Programada\Tarea1Programada\Tarea1Programada
//"C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe" Program.cs


using System;

class Program
{
    // ===============================
    // MÉTODOS DE LA CALCULADORA
    // ===============================

    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static double Restar(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;
        }

        return a / b;
    }

    // ===============================
    // VALIDACIÓN DE EDAD
    // ===============================

    static void ValidarEdad(int edad)
    {
        if (edad < 18)
            Console.WriteLine("Acceso denegado.");
        else
            Console.WriteLine("Bienvenido al sistema.");
    }

    // ===============================
    // CREACIÓN DE PERFIL
    // ===============================

    static void CrearPerfil(string nombre, string hobby = "Dormir")
    {
        Console.WriteLine("\nPerfil creado:");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Hobby: " + hobby);
    }

    // ===============================
    // MÉTODO PRINCIPAL
    // ===============================

    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema Modular ===\n");

        // Calculadora
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nResultados:");
        Console.WriteLine("Suma: " + Sumar(num1, num2));
        Console.WriteLine("Resta: " + Restar(num1, num2));
        Console.WriteLine("Multiplicación: " + Multiplicar(num1, num2));
        Console.WriteLine("División: " + Dividir(num1, num2));

        // Validador
        Console.Write("\nIngrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        ValidarEdad(edad);

        // Perfil
        CrearPerfil("Rubén Franco", "Programar");
        CrearPerfil("Invitado");

        Console.WriteLine("\nPrograma finalizado.");
        Console.ReadKey();
    }
}
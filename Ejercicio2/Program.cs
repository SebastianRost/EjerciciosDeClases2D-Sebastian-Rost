using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            //Se debe validar que el número sea mayor que cero,
            //caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!"

            int numero;
            double cuadrado;
            double cubo;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numero = int.Parse(Console.ReadLine());
            }
            cuadrado = Math.Pow(numero,2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado del numero es: {0} y el cubo: {1} ", cuadrado, cubo);

        }
    }
}

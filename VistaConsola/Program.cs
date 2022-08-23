using System;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            nombre = "Sebas"; //Console.ReadLine();
            string edadIngresada = Console.ReadLine();
            //int edad = int.Parse(edadIngresada);
            int edad;
            bool resultado = int.TryParse(edadIngresada, out edad);
            float precio = 45.75f;
            int numero = 30;

            //menos preciso
            double doble = 36.5;
            //mayor precision y tamaño
            decimal numDec = 25.4M;
            Console.WriteLine($"Precio: ${precio}");
            Console.WriteLine($"numero es: ${numero}");
            Console.WriteLine($"numero es: ${doble}");
            Console.WriteLine($"numero es: ${numDec}");
            if (resultado != false && edad > 18)
            {

                Console.WriteLine("Hola {0} {2} su edad es {1} ", nombre, edad + 2, Environment.NewLine);
            }
            else
            {
                Console.WriteLine("no es valido");
            }

            float precioConComa = 45.33f;

            //conversion explícita (no te importa perder datos)
            int entero = (int)precioConComa;

            //conversion implícita
            float otraConComa = entero;

            //Console.WriteLine("Hello World!");
            string[] nombres = new string[5];
            nombres[0] = "pepe";
            nombres[1] = "ass";
            nombres[2] = "dada";
            nombres[3] = "qq";
            nombres[4] = "lllll";
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            string[] paises = { "Bras", "arg", "peru" };
            foreach (string item in paises)
            {
                Console.WriteLine(item);
            }
        }
    }
}

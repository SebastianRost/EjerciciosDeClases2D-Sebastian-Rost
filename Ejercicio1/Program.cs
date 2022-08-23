using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar.
            //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
            int[] numeros = new int[5];
            bool[] validacion = new bool[5];
            int flagMayor = 0;
            int flagMenor = 0;
            int mayor = 0;
            int menor = 0;
            int acum = 0;
            float promedio;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                validacion[i] = int.TryParse(Console.ReadLine(), out numeros[i]);

                if (flagMayor == 0 || numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    flagMayor = 1;
                }
                if (flagMenor == 0 || numeros[i] < menor)
                {
                    menor = numeros[i];
                    flagMenor = 1;
                }
                acum += numeros[i];
            }

            promedio = (float)acum / 5;
            Console.WriteLine("Numero maximo: {0} , numero minimo: {1}, promedio: {2}", mayor, menor, promedio);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Instruccion ForEach";
            int[] Edades = new int[5];
            Array(Edades);
            Console.ReadKey();

        }

        static void Array(int[] Edades)
        {
            int Total = 0;
            Edades = new int[5];
            for(int x = 0; x < Edades.Length; x++)
            {
                Console.WriteLine("Ingresa la edad del estudiante " + (x + 1) + ":");
                Edades[x] = int.Parse(Console.ReadLine());
            }
            foreach(int element in Edades)
            {
                Total = Total + element;
            }

            Console.WriteLine("La sumatoria de las edades es: " + Total);

        }
    }
}

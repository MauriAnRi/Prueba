using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bola_8_para_deciciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> miCola = new Queue<string>();
            miCola.Enqueue("Sí");
            miCola.Enqueue("No");
            miCola.Enqueue("Quizas");
            miCola.Enqueue("Ni pensarlo");
            miCola.Enqueue("Haz tu pregunta mas directa");
            miCola.Enqueue("Tienes otra opcion?");
            String[] vec = miCola.ToArray();
            int cont = 0;

            Random ra1 = new Random();

            int des = ra1.Next(0,5);

            Random ra2 = new Random();
           
            while (true)
            {
                int showtime = ra2.Next(1,5);
                if (cont > 30)
                {
                    Console.WriteLine("Vuelve a intentar, lo siento tengo dolor de cabeza");
                    break;
                }
                if (showtime == des && cont > 10)
                {
                    Console.WriteLine(vec[des]);
                    break;
                }
                Thread.Sleep(100);
                Console.WriteLine(showtime);
                cont=cont+1;
            }
            Console.ReadKey();
        }
    }
}

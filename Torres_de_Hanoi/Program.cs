using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Keep the console window open in debug mode.

            Console.WriteLine("TORRES DE HANOI");
            Console.WriteLine("3 torres");
            Console.WriteLine("");
            Console.WriteLine("Introduce el numero de discos:");
            int n = Int16.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Has seleccionado " + n + " discos");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Indica I para iterativo y R para recursivo");
            string s = Console.ReadLine();
            if (s.Equals("I") || s.Equals("i"))
            {
                Hanoi hanoi= new Hanoi();
                
                Pila ini = new Pila(n);
                Pila aux = new Pila();
                Pila fin = new Pila();
                int contador = 1;

                Console.WriteLine("Situación INICIAL:");
                Console.WriteLine("Pila inicial --> " + ini.toString());
                Console.WriteLine("Pila auxiliar --> " + aux.toString());
                Console.WriteLine("Pila final --> " + fin.toString());
                Console.WriteLine("");
                Console.WriteLine("");

                
                int pasoAnterior = 0;
                
                for (int i=0; i< (Math.Pow(2,n))-1; i++)
                {
                    pasoAnterior = hanoi.iterativo(n, pasoAnterior, ini, fin, aux);
                    Console.WriteLine("Situación tras el movimiento " + contador + ":");
                    Console.WriteLine("Pila inicial --> " + ini.toString());
                    Console.WriteLine("Pila auxiliar --> " + aux.toString());
                    Console.WriteLine("Pila final --> " + fin.toString());
                    Console.WriteLine("");
                    Console.WriteLine("");
                   




                    contador++;
                }
                
                

            }
            else if (s.Equals("R") || s.Equals("r"))
            {
                Hanoi hanoi = new Hanoi();
                Pila ini = new Pila(n);
                Pila aux = new Pila();
                Pila fin = new Pila();


                Console.WriteLine("Situación INICIAL:");
                Console.WriteLine("Pila inicial --> " + ini.toString());
                Console.WriteLine("Pila auxiliar --> " + aux.toString());
                Console.WriteLine("Pila final --> " + fin.toString());
                Console.WriteLine("");
                Console.WriteLine("");

                hanoi.recursivo(n, ini, fin, aux);




            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

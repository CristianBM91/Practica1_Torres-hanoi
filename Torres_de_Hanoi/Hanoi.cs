using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (b.Size == 0)
            {
                b.push(a.pop());
               
            }
            else if (!a.isEmpty() && a.Elementos[a.Size-1].Valor < b.Elementos[b.Size-1].Valor)
            {
                b.push(a.pop());
                
            }
            else if (b.isEmpty())
            {
                b.push(a.pop());
            }
            
            
        }

        public int iterativo(int n,int pasoAnterior, Pila ini, Pila fin, Pila aux)
        {


            // Si es posible, lleva el disco 1 sobre un disco de número par.
            // Si no es posible, llévalo a  la pila aux si n es par o a fin si n es impar.

            // Si todos los discos están en C, fin.Si no, mueve un disco que no sea el 1 y vuelve al paso 1.
            
            if(pasoAnterior != 1)
            {
                if (ini.Top == 1)
                {
                    if (aux.Top % 2 == 0 && aux.Size != 0)
                    {
                        mover_disco(ini, aux);
                    }
                    else if (fin.Top % 2 == 0 && fin.Size != 0)
                    {
                        mover_disco(ini, fin);
                    }
                    else if (n % 2 == 0 && aux.isEmpty())
                    {
                        mover_disco(ini, aux);
                    }
                    else if (n % 2 != 0 && fin.isEmpty())
                    {
                        mover_disco(ini, fin);
                    }

                }
                else if (aux.Top == 1)
                {
                    if (ini.Top % 2 == 0 && ini.Size != 0)
                    {
                        mover_disco(aux, ini);
                    }
                    else if (fin.Top % 2 == 0 && fin.Size != 0)
                    {
                        mover_disco(aux, fin);
                    }
                    else if (ini.isEmpty())
                    {
                        mover_disco(aux, ini);
                    }
                    else if (fin.isEmpty())
                    {
                        mover_disco(aux, fin);
                    }
                }
                else if (fin.Top == 1)
                {
                    if (ini.Top % 2 == 0 && ini.Size != 0)
                    {
                        mover_disco(fin, ini);
                        
                    }
                    else if (aux.Top % 2 == 0 && aux.Size != 0)
                    {
                        mover_disco(fin, aux);
                       
                    }
                    else if (n % 2 == 0 && aux.isEmpty())
                    {
                        mover_disco(ini, aux);
                        
                    }
                    else if (n % 2 != 0 && fin.isEmpty())
                    {
                        mover_disco(ini, fin);
                        
                    }
                }
                return 1;
            }
            else if (pasoAnterior == 1)
            {
                if (ini.Top == 1)
                {
                    if (aux.Top < fin.Top && aux.Top != 0)
                    {
                        mover_disco(aux, fin);
                    }
                    else if (fin.Top < aux.Top && fin.Top != 0)
                    {
                        mover_disco(fin, aux);
                    }
                    else
                    {
                        mover_disco(fin,aux);
                    }
                }
                else if (aux.Top == 1)
                {
                    if (ini.Top < fin.Top && ini.Top != 0)
                    {
                    mover_disco(ini, fin);

                    }
                    else if (fin.Top < ini.Top && fin.Top != 0)
                    {
                    mover_disco(fin, ini);

                    }
                    else
                    {
                        mover_disco(ini, fin);
                    }


                }
                else if (fin.Top == 1)
                {
                    if (aux.Top < ini.Top && aux.Top != 0)
                    {
                        mover_disco(aux, ini);

                    }
                    else if (ini.Top < aux.Top && ini.Top != 0)
                    {
                        mover_disco(ini, aux);

                    }
                    else if (ini.Top < aux.Top && ini.Top == 0)
                    {
                        mover_disco(aux, ini);

                    }
                    else
                    {

                            mover_disco(ini, aux);
 
                    }


                }
               

                return 0;
            }
            else
            {
                return 0;
            }
            











            
        }



        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {

            if (n == 1)
            {
                mover_disco(ini, fin);



            }
            else
            {
                recursivo(n - 1, ini, aux, fin);

                mover_disco(ini, fin);

                recursivo(n - 1, aux, fin, ini);



                Console.WriteLine("Pila inicial --> " + ini.toString());
                Console.WriteLine("Pila auxiliar --> " + aux.toString());
                Console.WriteLine("Pila final --> " + fin.toString());
                Console.WriteLine("");
                Console.WriteLine("");

            }



            return 0;




        }

    }
}

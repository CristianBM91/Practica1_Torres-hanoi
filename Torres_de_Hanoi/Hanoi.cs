using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            b.push(a.pop());
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            Pila emisora = new Pila();
            Pila receptora = new Pila();
            Pila noReceptora = new Pila();

            if (ini.Top%2 != 0)
            {
                fin.push(ini.pop());
            }
            else
            {
                aux.push(ini.pop());
            }
            
            
            
            


            return 0;
        }

    }
}

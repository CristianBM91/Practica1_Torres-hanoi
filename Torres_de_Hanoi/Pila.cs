using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        /* TODO: Elegir tipo de Top
        public String Top { get; set; }        
        */
        public int Top { get; set; }

        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        */
        public List<Disco> Elementos { get; set; }

        /* TODO: Implementar métodos */
        public Pila()
        {
            this.Size = 0;
            this.Top = 0;
            this.Elementos = new List<Disco>();
        }

        public Pila(int nDiscos)
        {
            this.Elementos= new List<Disco>();
            this.Size = nDiscos;
            for(int i = 0; i < nDiscos; i++)
            {
                Disco disco = new Disco();
                disco.Valor = nDiscos - i;
                this.Elementos.Add(disco);
                
            }
            this.Top = 1;

        }

        public void push(Disco d)
        {
            if (this.Size == 0)
            {
                this.Elementos.Add(d);
                this.Size++;
                this.Top = d.Valor;
            }
            else if(d.Valor < this.Elementos[this.Size - 1].Valor)
            {
                this.Elementos.Add(d);
                this.Size++;
                this.Top = d.Valor;
            }
            
        }

        public Disco pop()
        {
            Disco disco = new Disco();
            if (this.Size > 1)
            {
                
                disco = this.Elementos[this.Size - 1];
                this.Elementos.RemoveAt(this.Size - 1);
                this.Size--;
                this.Top =  this.Elementos[this.Size - 1].Valor; 
                return disco;
            }
            else if (this.Size == 1)
            {
                disco = this.Elementos[this.Size - 1];
                this.Elementos.RemoveAt(this.Size - 1);
                this.Size = 0;
                this.Top = 0;
                return disco;
            }
            else
            {
                return disco;
            }
        }                

        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public string toString()
        {
            
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i<this.Size;i++)
            {
                stringBuilder.Append(Elementos[i].Valor + ", ");
            }
            return stringBuilder.ToString();
        }

    }
}

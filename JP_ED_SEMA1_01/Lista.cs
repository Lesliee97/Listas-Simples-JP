using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA1_01
{
    class Lista
    {
        public Nodo inicio;

        public Lista()
        {
            inicio = null;
        }
        
        //metodo insertar al inicio

        public void InsertarI(int item)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if(inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                inicio = auxiliar;
                auxiliar.siguiente = puntero;
            }
        }
        //metodo para insertar al final de la lista
        public void InsertarF (int item)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
          
            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
               while (puntero.siguiente!=null)
               {
                   puntero = puntero.siguiente;
               }
               puntero.siguiente = auxiliar;
            }
        }

        // metodo para insertar en una posicion especifica de la lista

       public void InsertarP(int item, int pos)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                Console.WriteLine("La lista está vacia, por lo tanto se va insertar en la 1a posición");
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                if(pos ==1)
                {
                    inicio = auxiliar;
                    puntero.siguiente = puntero;
                }
                else
                {
                    for (int i = 1; i < pos - 1;i++)
                    {
                        puntero = puntero.siguiente;
                        if (puntero.siguiente == null)
                            break;
                    }
                    // 12, 21, 13, 16, 20, 19
                    Nodo punteronext;
                    punteronext = puntero.siguiente;
                    puntero.siguiente = auxiliar; //16
                    auxiliar.siguiente = punteronext;
                }
            }
        }

        public void EliminarI()
       {
            if(inicio == null)
            {
                Console.WriteLine("Lista vacia, no se puede eliminar elemento");
            }
            else
            {
                inicio = inicio.siguiente;
            }
       }

       public void EliminarF()
        {
           if(inicio ==null)
           {
               Console.WriteLine("La lista vacia, no se puede eliminar el elemento");
           }
           else
           {
               Nodo punteroant, punteropost;
               punteroant = inicio;
               punteropost = inicio;

               while(punteropost.siguiente!=null)
               {
                   punteroant = punteropost;
                   punteropost = punteropost.siguiente;
               }
               punteroant.siguiente = null;
           }
        }

        public void mostrar()
       {
            if(inicio == null)
            {
                Console.WriteLine("LA LISTA ESTÁ VACIA");
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                Console.Write("{0} -> \t", puntero.dato);
                while(puntero.siguiente!=null)
                {
                    puntero = puntero.siguiente;
                    Console.Write("{0} -> \t", puntero.dato);
                }
            }
            Console.WriteLine();
       }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Pila
    {
        public Nodo tope;

        public Pila()
        {
            tope = null;      
        }

        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (tope == null)
            {
                tope = nuevo;
            }
            else
            { 
                nuevo.siguiente = tope;
                tope = nuevo;
                    }

        }

        public void Listar(ListBox lstPila)
        { 
            lstPila.Items.Clear();
            if (tope == null) lstPila.Items.Add("Pila vacia");
            else 
            {
                Nodo aux = tope;
                while (aux != null) 
                {
                    lstPila.Items.Add(aux.dato);
                    aux = aux.siguiente;
                }
            }
        }

        public string Eliminar()
        {
            if (tope == null) return "La lista esta vacìa";
            else 
            {
                Nodo aux = tope;
                tope = aux.siguiente;
                aux = null;
                return "Elementyo eliminado";
            }
        
        }

        public bool Buscar(int dato)
        {
            bool existe = false;
            if (tope == null) existe= false;
            else
            {
                Nodo aux = tope;
                while (aux != null)
                {
                    if(dato == aux.dato) existe= true;
                    aux = aux.siguiente;
                }
            }
            return existe;
        }
    }
}

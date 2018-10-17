using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lares Dominguez Brandon
            Queue queue = new Queue(); //Aqui se crea la colecccion Queue
            //Se agregan elementos a la coleccion que hemos creado con el metodo Enqueue
            queue.Enqueue(5); 
            queue.Enqueue(7);
            queue.Enqueue(9);
            Console.WriteLine("Elementos en Queue: "+queue.Count); //Se cuentan los elementos y se muestran
            Console.WriteLine("Ultimo elemento en Queue: " + queue.Dequeue()); //Muestra el ultimo valor de la coleccion y lo elimina con este meotodo.
            Console.WriteLine("Elementos en Queue: " + queue.Count); //Mostramos que se ha eliminado el ultimo valor.
            queue.TrimToSize(); //Este metodo lo que hace es ajustar la capacidad de la coleccion a la cantidad de elementos que se tiene en este momento.
            //Por tanto, su capacidad se ve alterada y en este caso es 3.
            
            Console.ReadKey();
        }
    }
}

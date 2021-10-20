using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosColecciones.Tipos
{
    class ColaPrioridad
    {

        public static void Execute()
        {

            //Crear y anadir elementos
            PriorityQueue<string, int> colaPrioridad = new PriorityQueue<string, int>();

            colaPrioridad.Enqueue("Opel", 2);
            colaPrioridad.Enqueue("Audi", 1);
            colaPrioridad.Enqueue("BMW", 3);


            //recibir elementos
            string resultPeek = colaPrioridad.Peek();
            string resultDequeue = colaPrioridad.Dequeue();
            string resultDequeue2 = colaPrioridad.EnqueueDequeue("Mazda", 3);
            Console.WriteLine(resultPeek); //Audi
            Console.WriteLine(resultDequeue); //Audi otra vez
            Console.WriteLine(resultDequeue2); //Opel
            
            //Limpiar la cola
            colaPrioridad.Clear();
        }
    }
}

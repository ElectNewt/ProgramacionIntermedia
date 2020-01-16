using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Generics
{
    public class OperationResult<T>
        where T : class, new() 
    {
        public bool Success => !MessageList.Any();
        public List<string> MessageList { get; private set; }
        public T Contenido { get; set; }

        public OperationResult()
        {
            MessageList = new List<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }

        public void SetSuccesResponse(T obj)
        {
            Contenido = obj;
        }
    }

    public class Ejemplo
    {
        public T EjemploGenericMethod<T>(T x)
        {
            return x;
        }

        public void Metodo2()
        {

        }
    }

    
}

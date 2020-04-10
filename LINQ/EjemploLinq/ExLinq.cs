using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploLinq
{
    public static class ExLinq
    {
        public static IEnumerable<T> Filtro<T>(this IEnumerable<T> source, Func<T, bool> predicado)
        {
            foreach(var item in source)
            {
                if (predicado(item))
                {
                    yield return item;
                }
            }
        }


    }
}

using System;

namespace NullCheck.Ejemplos
{
    public class EjemploPosibleFuturo
    {
        //posible en el futuro? public string Execute(PlaceholderClass test!)
        public string Execute(PlaceholderClass test)
        {
            if (test == null) throw new ArgumentNullException(nameof(test));

            return string.Empty;
        }
    }
}

namespace NullCheck.Ejemplos
{
    public class EjemploCsharp7
    {
        public string Execute()
        {
            string i = null;
            if (i is null)
            {
                return "El valor es null";
            }

            if (i is object)
            {
                return "El valor no es null";
            }

            if (!(i is null))
            {
                return "El valor no es null";
            }

            return string.Empty;
        }

    }
}

namespace NullCheck.Ejemplos
{
    public class EjemploCsharp9
    {
        public string Execute()
        {
            string i = null;
            if (i is not null)
            {
                return "El valor no es null";
            }

            return string.Empty;
        }
    }
}

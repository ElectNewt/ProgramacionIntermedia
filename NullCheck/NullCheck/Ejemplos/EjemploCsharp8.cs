namespace NullCheck.Ejemplos
{
    public class EjemploCsharp8
    {
        public string Execute()
        {
            string i = null;

            if (i is { })
            {
                return "this cast to true";
            }


            return string.Empty;
        }
    }
    
}

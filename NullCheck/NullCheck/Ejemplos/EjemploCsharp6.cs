namespace NullCheck.Ejemplos
{

    /// <summary>
    /// Ejemplo C#6
    /// </summary>
    public class EjemploCsharp6
    {

        public string Execute()
        {
            int i = 1;
            if(i == null)
            {
                return "el valor de I es null, y eso no puede ser";
            }

            if (i != null)
            {
                //Hacer el código
            }

            return string.Empty;
        }

        public string ExecuteOption2()
        {
            PlaceholderClass obj = null;
            if(obj != null)
            {
                return "el if siempre devuelve verdadero";
            }

            return string.Empty;
        }
    }
}

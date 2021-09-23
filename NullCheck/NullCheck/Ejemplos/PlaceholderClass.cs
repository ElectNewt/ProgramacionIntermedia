namespace NullCheck.Ejemplos
{
    public class PlaceholderClass
    {
        public static bool operator ==(PlaceholderClass lhs, PlaceholderClass rhs)
        {
            return true;
        }

        public static bool operator !=(PlaceholderClass lhs, PlaceholderClass rhs)
        {
            return true;
        }
    }
}

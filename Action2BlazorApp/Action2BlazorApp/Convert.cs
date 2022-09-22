namespace Convert
{
    public class Convert
    {
        public static double f2c(double f)
        {
            return (f - 32) * 5 / 9;
        }

        public static double c2f(double c)
        {
            return (c * 9 / 5) + 32;
        }
    }
}

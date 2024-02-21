using ShaperLibriary;
namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public static class ShaperTest
    {
        public static double AreaResult(double a, double? b = null, double? c = null)
        {
            if (b == null && c == null || b == null && c != null || b != null && c == null)
            {
                Circle circle = new Circle();
                circle.r = a;
                return circle.Area();
            }
            Triangle triangle = new Triangle();
            triangle.a = a; triangle.b = (double)b; triangle.c = (double)c;
            return triangle.Area();
        }
    }

}

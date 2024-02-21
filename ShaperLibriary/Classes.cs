namespace ShaperLibriary
{
    public abstract class Shape
    {
        public abstract double Area();
        
        
    }
    public class Circle : Shape
    {
        public double r;
        public override double Area()
        {
            return Math.PI * Math.Pow(r,2);
        }       
    }
    public class Triangle: Shape
    {
        public double a,b,c;
        
        public override double Area() { double p = (a + b + c) / 2; return Math.Sqrt((p - a) * (p - b) * (p - c) * p);  }
        public void IsRectangular() => Console.WriteLine( a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b ? "IsRectangular" : null);
    }
}

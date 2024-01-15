namespace operators2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whaat is the area of your circle: ");
            double radius = double.Parse(Console.ReadLine());

            double sum= AreaOfCircle(radius);
            Console.WriteLine($"The area of circle with radius of {radius} is {sum}");
        }
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

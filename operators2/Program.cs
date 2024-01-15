namespace operators2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            Console.WriteLine("enter Number1: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Number2: ");
            b = int.Parse(Console.ReadLine());


            int total = a + b;
            Console.WriteLine($"{a} + {b} is  {total}\n");

            //int quotient = a / b;
            int Quotient = a / b;
            Console.WriteLine($"{a} / {b} is {Quotient}\n");


            //int remainder = a % b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is remainder {remainder}\n");


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

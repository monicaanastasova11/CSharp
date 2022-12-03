class Program
{
    static void Main(string[]args)
    {
        PrintGreeting();

        int a = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        double area = CalculateAreaofTriangle(a, h);

        Console.WriteLine(area);


    }

    private static void PrintGreeting()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("How are you");
        Console.WriteLine("Give me 2 numbers and I will calc the area of triangle for you");
    }

    private static double CalculateAreaofTriangle(int a, int h)
    {
        double result = a * h / 2;

        return result;
    }

    
}

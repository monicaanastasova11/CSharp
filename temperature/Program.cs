class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter your body temp in Fahrenh");

        double temp = double.Parse(Console.ReadLine());

        temp=ConvertFarenheitoCelsius(temp);

        Console.WriteLine($"Your body temp is Celsium degrees is{temp}");

        if(temp>37)
        {
            Console.WriteLine("You are ill");
        }
    }

    public static double ConvertFarenheitoCelsius(double tempF)
    {
        double tempC = (tempF - 32) * 5 / 9;

        return tempC;
    }
}

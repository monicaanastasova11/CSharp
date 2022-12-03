
class Program
{
    static void Main(string[] args)

    {
       

        PrintGreeting();

        string name = Console.ReadLine();

        PrintGreeting(name);

        int age=int.Parse(Console.ReadLine());

        if(age>18)
        {
            Console.WriteLine("Enter");
        }
        else
        {
            Console.WriteLine("Go home");
        }

        //int[] numbers = new int[] { 3, 4, 5, 6, 7, 8, 9 };
        //int minValue = FindMinValue(numbers);
        //Console.WriteLine(minValue);


    }






    public static int FindMinValue(int[] numbers)
    {
        var MinNumber = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {

            int x = numbers[i];

            if (MinNumber > x)
            {
                MinNumber = x;
            }
        }
        return MinNumber;
    }


    public static void PrintGreeting()
    {
        Console.WriteLine("Hello.What is your name?");
        
    }

    public static void PrintGreeting(string name)
    {
        Console.WriteLine($"Hello{name}");
        Console.WriteLine("How old are you?");
        
    }

}



class Program
{
    static void Main(string[]args)
    {
        //Входни данни
        int a =int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        //Бизнес логика
        int sumofseconds = a + b + c;

        int minutes = sumofseconds / 60;

        int restSeconds = sumofseconds % 60;

        Console.WriteLine($"{minutes}:{restSeconds}");
    }
    


    
}

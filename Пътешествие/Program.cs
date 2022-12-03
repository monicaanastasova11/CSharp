class Program
{
    static void Main(string[] args)
    {
        //Входни данни
        double бюджет = double.Parse(Console.ReadLine());
        string сезон = (Console.ReadLine());

        double price = 0.00;



        if (бюджет <= 100)
        {
            if (сезон == "summer")
            {

                price = бюджет * 0.3;
                Console.WriteLine("Някъде в България");
                Console.WriteLine("Camp-{0:F2}", price);

            }
            else if (сезон == "winter")
            {

                price = бюджет * 0.7;
                Console.WriteLine("Някъде в България");
                Console.WriteLine("Hotel-{0:F2}", price);
            }
        }


        else if (бюджет <= 1000)
        {
            if (сезон == "summer")
            {

                price = бюджет * 0.4;
                Console.WriteLine("Някъде на Балканите");
                Console.WriteLine("Camp-{0:F2}", price);
            }
            else if (сезон == "winter")
            {

                price = бюджет * 0.8;
                Console.WriteLine("Някъде на Балканите");
                Console.WriteLine("Hotel-{0:F2}", price);
            }
        }



        else if (бюджет > 1000)
        {
            price = бюджет * 0.9;
            Console.WriteLine("Някъде из Европа");
            Console.WriteLine("Hotel-{0:F2}", price);
        }



    }

    
}

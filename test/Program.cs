class Program
{
    static void Main(string[]args)
    {
        //Входни данни 
        //Приемаме възрастта на Лили 
        int age = int.Parse(Console.ReadLine());

        //Каква ще бъде цената на пералнята?
        double priceofwashingMachine = double.Parse(Console.ReadLine());

        //Каква е цената на играчката?
        int presentPrice = int.Parse(Console.ReadLine());

        //Бизнес логика:
        double moneyforbirthday = 10;
        double savedmoney = 0;
        int numberoftoys = 0;


        for(int currentYear = 1; currentYear <= age; currentYear++)
        {
            if(currentYear % 2 ==0)
            {
                //На всеки четен рожден ден на Лили тя получава пари
                //Първия път тези пари са 10 лв.
                savedmoney += moneyforbirthday ;

                //Намаляваме парите на Лили, защото брат и си взема 1 лев 
                savedmoney--;

                //Увеличаваме парите, които ще получи Лили следващия път
                moneyforbirthday += 10;
            }

            else
            {
                numberoftoys++;
            }

            //Продаваме играчките 
            double moneyFromtoys = numberoftoys * presentPrice;
            savedmoney += moneyFromtoys;

            if(savedmoney >= priceofwashingMachine)
            {
                Console.WriteLine($"Yes!{savedmoney-priceofwashingMachine}:0.00");
            }
            else
            {
                Console.WriteLine($"No!{Math.Abs(savedmoney - priceofwashingMachine)}:0.00");
            }

        }
    }
}

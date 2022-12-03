class Program
{
    static void Main(string[]args)
    {
        //Входни данни 
        int chasnaizpita=int.Parse(Console.ReadLine());
        int minutinaizpita=int.Parse(Console.ReadLine());
        int chasnapristigane=int.Parse(Console.ReadLine());
        int minutinapristigane = int.Parse(Console.ReadLine());

        //Бизнес логика
        int vremenaizpita = chasnaizpita * 60 / minutinaizpita;
        int vremenapristigane=chasnapristigane * 60 / minutinapristigane;

        //Изходни данни 
        if(vremenapristigane>chasnaizpita)
        {
            int vremenazakusnenie = chasnaizpita - vremenapristigane;
            if (vremenazakusnenie<60)
            {

            }
        }
        
        



    }
}

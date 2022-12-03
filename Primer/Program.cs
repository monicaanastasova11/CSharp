class Program
{
    static void Main (string[]args)
    {
        double strana = double.Parse(Console.ReadLine());
        double visochina=double.Parse(Console.ReadLine());

        double areaofTriangle = CalculateareaofTriangle(strana, visochina);

        double strana2=double.Parse(Console.ReadLine());
        double visochina2=double.Parse(Console.ReadLine());

        double areaofTriangle2 = CalculateareaofTriangle(strana2, visochina2);

        
        
    }

    public static double CalculateareaofTriangle(double x, double y)
    {
       double area = x * y/ 2;
        return 0;
    }
}

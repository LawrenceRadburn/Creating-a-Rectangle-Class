using Hello_World;

internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle myRect = new Rectangle(10, 5);
        Rectangle myRect1 = new Rectangle();
        Rectangle myRect2 = new Rectangle(5);

        int theArea = myRect.CalculateArea();
        int thePerimeter = myRect.CalculatePerimeter();
        



        Console.WriteLine("The area of the first rectangle is " + theArea);
        Console.WriteLine("The perimeter is " + thePerimeter);
        Console.WriteLine();

        Console.WriteLine("The area of the second rectangle is " + myRect1.CalculateArea());
        Console.WriteLine("The perimeter of the second rectangle is " + myRect1.CalculatePerimeter());
        Console.WriteLine();

        Console.WriteLine("The area of the third rectangle is " + myRect2.CalculateArea());
        Console.WriteLine("The perimeter of the third rectangle is " + myRect2.CalculatePerimeter());
        Console.WriteLine();
    }
}

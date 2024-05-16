using Hello_World;

internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle myRectangle = new Rectangle();
        myRectangle.setLength(10);
        myRectangle.setWidth(5);

        int theArea = myRectangle.CalculateArea();
        int thePerimeter = myRectangle.CalculatePermiter();

        Console.WriteLine("The area is " + theArea);
        Console.WriteLine("The perimeter is " + thePerimeter);
    }
}

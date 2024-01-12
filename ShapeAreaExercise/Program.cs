namespace ShapeAreaExercise;
class Program
{
    static void Main(string[] args)
    {
        //Get user input for your circle method. Then call your circle method.
        Console.WriteLine("CALCULATE THE AREA OF A CIRCLE");
        Console.Write("Enter radius: ");
        int? userRadius = Convert.ToInt32(Console.ReadLine());
        double radius = Convert.ToInt64(userRadius);

        double circleArea = Circle(radius);
        Console.WriteLine($"Area: {circleArea}");

        Console.WriteLine();

        //Get user input for your triangle method. Then call your triangle method.
        Console.WriteLine("CALCULATE THE AREA OF A TRIANGLE");
        Console.Write("Length of longest side (base): ");
        int? userBase = Convert.ToInt32(Console.ReadLine());
        double baseLength = Convert.ToInt64(userBase);

        Console.Write("Height from base to opposite corner, at a 90° angle: ");
        int? userTriHeight = Convert.ToInt32(Console.ReadLine());
        double triangleHeight = Convert.ToInt64(userTriHeight);

        double triangleArea = Triangle(baseLength, triangleHeight);
        Console.WriteLine($"Area: {triangleArea}");

        Console.WriteLine();

        //Get user input for your rectangle method. Then call your rectangle method.
        Console.WriteLine("CALCULATE THE AREA OF A RECTANGLE");
        Console.Write("Length of one side: ");
        int? userLength = Convert.ToInt32(Console.ReadLine());
        double rectangleLength = Convert.ToInt64(userLength);

        Console.Write("Height of other side: ");
        int? userRectHeight = Convert.ToInt32(Console.ReadLine());
        double rectangleHeight = Convert.ToInt64(userRectHeight);

        double rectangleArea = Rectangle(rectangleLength, rectangleHeight);
        Console.WriteLine($"Area: {rectangleArea}");

        Console.WriteLine();

        //Get user input for your square method. Then call your square method.
        Console.WriteLine("CALCULATE THE AREA OF A SQUARE");
        Console.Write("Length of sides: ");
        int? userSide = Convert.ToInt32(Console.ReadLine());
        double side = Convert.ToInt64(userSide);

        double squareArea = Square(side);
        Console.WriteLine($"Area: {squareArea}");
    }

    // Method to calculate area of a circle
    public static double Circle(double radius)
    {
        double area = radius * 2 * Math.PI;
        return area;
    }

    //Method to calculate area of a triangle
    public static double Triangle(double baseLength, double height)
    {
        double area = baseLength * height / 2;
        return area;
    }

    //Method to calculate area of a rectangle
    public static double Rectangle(double length, double width)
    {
        double area = length * width;
        return area;
    }

    //Method to calculate area of a square
    public static double Square(double side)
    {
        double area = Math.Pow(side, 2);
        return area;
    }
}


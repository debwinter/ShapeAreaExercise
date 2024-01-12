namespace ShapeAreaExercise;
class Program
{
    static void Main(string[] args)
    {
        
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


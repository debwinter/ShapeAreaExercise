using static System.Collections.Specialized.BitVector32;

namespace ShapeAreaExercise;
class Program
{
    static void Main(string[] args)
    {
        //Prompt the user to choose a shape
        Console.WriteLine("CALCLUATE AREA OF A SHAPE");
        Console.WriteLine("Choose your shape below.");
        char selection = UserSelection();
        string shapeName = ShapeConfirmation(selection);

        //Confirm user input
        char confirmation;
        
        switch (selection)
        {
            case 'C' or 'T' or 'R' or 'S' or 'c' or 't' or 'r' or 's':
                Console.WriteLine();
                Console.Write($"You have chosen a {shapeName}. Is that correct? (y/n): ");
                confirmation = Convert.ToChar(Console.ReadLine());
                break;

            default:
                Console.WriteLine();
                Console.WriteLine("I'm sorry, I did not understand that input.");
                return;
        }

        //Execute code if correct
        switch (confirmation)
        {
            case 'Y' or 'y':
                double userArea = GetUserArea(selection);
                Console.WriteLine();
                Console.WriteLine($"The area of your {shapeName} is: \n" +
                    $"{userArea}");
                return;

            case 'N' or 'n':
                Console.WriteLine();
                Console.WriteLine("I'm sorry, I must have made a mistake.");
                return;

            default:
                Console.WriteLine();
                Console.WriteLine("I'm sorry, I did not understand that input.");
                return;
        }
    }

    //Method to collect user input
    public static char UserSelection()
    {
        Console.WriteLine();
        Console.WriteLine("For a circle, type 'C';");
        Console.WriteLine("For a triangle, type 'T';");
        Console.WriteLine("For a rectangle, type 'R';");
        Console.WriteLine("For a square, type 'S'.");
        Console.WriteLine();
        Console.Write("Type only the letter, without quotes: ");

        char selection = Convert.ToChar(Console.ReadLine());
        return selection;
    }

    //Method to confirm user input
    public static string ShapeConfirmation(char userSelection)
    {
        string shapeName;

        switch (userSelection)
        {
            case 'C' or 'c':
                shapeName = "circle";
                break;

            case 'T' or 't':
                shapeName = "triangle";
                break;

            case 'R' or 'r':
                shapeName = "rectangle";
                break;

            case 'S' or 's':
                shapeName = "square";
                break;

            default:
                shapeName = "NULL";
                break;
        }

        return shapeName;
    }


    //Method to execute user input
    public static double GetUserArea(char userSelection)
    {
        double userArea;

        switch (userSelection)
        {
            case 'C' or 'c':
                //Get user input for your circle method. Then call your circle method.
                Console.WriteLine();
                Console.Write("Length of radius: ");
                int? userRadius = Convert.ToInt32(Console.ReadLine());
                double radius = Convert.ToInt64(userRadius);

                userArea = Circle(radius);
                break;

            case 'T' or 't':
                //Get user input for your triangle method. Then call your triangle method.
                Console.WriteLine();
                Console.Write("Length of longest side (base): ");
                int? userBase = Convert.ToInt32(Console.ReadLine());
                double baseLength = Convert.ToInt64(userBase);

                Console.Write("Length from base to opposite corner, measured at a 90° angle: ");
                int? userTriHeight = Convert.ToInt32(Console.ReadLine());
                double triangleHeight = Convert.ToInt64(userTriHeight);

                userArea = Triangle(baseLength, triangleHeight);
                break;

            case 'R' or 'r':
                //Get user input for your rectangle method. Then call your rectangle method.
                Console.WriteLine();
                Console.Write("Length of one side: ");
                int? userLength = Convert.ToInt32(Console.ReadLine());
                double rectangleLength = Convert.ToInt64(userLength);

                Console.Write("Length of other side: ");
                int? userRectHeight = Convert.ToInt32(Console.ReadLine());
                double rectangleHeight = Convert.ToInt64(userRectHeight);

                userArea = Rectangle(rectangleLength, rectangleHeight);
                break;

            case 'S' or 's':
                //Get user input for your square method. Then call your square method.
                Console.WriteLine();
                Console.Write("Length of sides: ");
                int? userSide = Convert.ToInt32(Console.ReadLine());
                double side = Convert.ToInt64(userSide);

                userArea = Square(side);
                break;

            default:
                userArea = 0;
                break;
        }

        return userArea;
    }

    // Method to calculate area of a circle
    public static double Circle(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
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


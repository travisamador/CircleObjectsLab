using CircleObjectsLab;
bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Welcome to the Circle Tester.");
    Console.WriteLine("Please enter the radius of a circle: ");
    Circle userCircle = new Circle(Validator.Double());
    Console.WriteLine($"The circumference of your circle is: {userCircle.CalculateFormattedCircumference()}");
    Console.WriteLine($"The area of your circle is: {userCircle.CalculateFormattedArea()}");
    Console.WriteLine("Would you like to test another circle? (y/n)");
    while (true)
    {
        string answer = Validator.YesOrNo();
        if (answer == "y")
        {
            break;
        }
        else if (answer == "n")
        {
            Console.WriteLine($"Goodbye, you made {Circle.circleCount} circle(s).");
            runProgram = false;
            break;
        }
    }
}
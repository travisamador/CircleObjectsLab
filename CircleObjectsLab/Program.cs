using CircleObjectsLab;
Console.WriteLine("Welcome to the Circle Tester.");
bool runProgram = true;
while (runProgram)
{  
    Console.WriteLine("Please enter the radius of a circle: ");
    Circle userCircle = new Circle(Validator.Double());
    Console.WriteLine($"The circumference of your circle is: {userCircle.CalculateFormattedCircumference()}");
    Console.WriteLine($"The area of your circle is: {userCircle.CalculateFormattedArea()}");
    Console.WriteLine("Would you like to test another circle? (y/n)");
    string answer = Validator.YesOrNo();
    if (answer == "n")
    {
        Console.WriteLine($"Goodbye, you made {Circle.circleCount} circle(s).");
        runProgram = false;
    }   
}
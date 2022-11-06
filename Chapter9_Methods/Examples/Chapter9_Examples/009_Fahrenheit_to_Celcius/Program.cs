static void checkHealth(double fahrenheit)
{
    double celcius = (fahrenheit - 32)* 5/ 9;
    Console.WriteLine("Your body temperature in celcius is : {0}",celcius);
    if (celcius > 37.0)
        Console.WriteLine("You are ill.Please visit a doctor!");
    else
        Console.WriteLine("You fine my man. Enjoy Life");
}

Console.Write("Your body temperature(in Fahrenheit :");
double tempinF = double.Parse(Console.ReadLine());
checkHealth(tempinF);

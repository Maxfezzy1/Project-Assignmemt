internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please Enter your Fahrenheit Temperature you wish to convert to Celsius:");
        var UserFahrenheit = Convert.ToDouble(Console.ReadLine());

        var Celsius = (UserFahrenheit - 32) * 5 / 9;

        Console.WriteLine("The Fahrenheit Temperature you wish to convert to Celsius is {0}: ", Celsius);




        Console.Write("Please Enter your Celsius Temperature you wish to convert to Fahrenheit: ");
        var celsius = Convert.ToDouble(Console.ReadLine());

        var fahrenheit = ((celsius * 9) / 5) + 32;

        Console.WriteLine(" The Celsius Temperature you wish to convert to Fahrenheit is {0}: " , fahrenheit);
        



    }




}
   





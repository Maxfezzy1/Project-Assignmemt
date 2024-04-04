internal class Program
{
  private static void Main(string[] args)
  {
        
    Begin:
        Console.WriteLine("Which Temperature do you which to convert: 1 - Fahrenheit, 2 - Celsius");
        var Userchoice = Console.ReadLine();
        switch (Userchoice)
        {
            case "1":
                goto Start1;
            case "2":
                goto Start2;
            default:
                Console.WriteLine("Your choice {0} is invalid, please choose between 1 and 2", Userchoice);
                goto Begin;
        }



        Start1:
        Console.WriteLine("Enter Temperature in Fahrenheit");
        var input1 = Console.ReadLine();
        if (double.TryParse(input1, out double fahrenheit1))
        {
            double celsius1 = CelsiusFahrenheit1(fahrenheit1);
            Console.WriteLine("The converted Fahrenheit temperature is:" + celsius1);
        }
        else
        {
            Console.WriteLine("Invalid input.Please enter a valid numeric value for fahrenheit.");
            goto Start1;
        }
        static double CelsiusFahrenheit1(double fahrenheit1)
        {
            return (fahrenheit1 - 32) * 5 / 9;
        }





    Decide:
        Console.WriteLine("Do you wish to convert from celsius to fahrenheit, Yes or No");
        var Userdecision = Console.ReadLine();
        switch (Userdecision.ToUpper())
        {
            case "YES":
                goto Start2;
            case "NO":
                goto End;
            default:
                Console.WriteLine("Your Choice {0} is invalid.... Please try again", Userdecision);
                goto Decide;
        }



        Start2:
        Console.WriteLine("Enter Temperature in Celsius");
        var input = Console.ReadLine();
        if(double.TryParse(input, out double celsius))
        {
            double fahrenheit = CelsiusFahrenheit(celsius);
            Console.WriteLine("The converted Fahrenheit temperature is:" + fahrenheit);
        }
        else
        {
            Console.WriteLine("Invalid input.Please enter a valid numeric value for celsius.");
            goto Start2;
        }
        static double CelsiusFahrenheit(double celsius)
        {
            return ((celsius * 9) / 5) + 32;
           
        }

        Decide1:
        Console.WriteLine("Do you wish to convert from fahrenheit to Celsius, Yes or No");
        var Userdecision2 = Console.ReadLine();
        switch (Userdecision2.ToUpper())
        {
            case "YES":
                goto Start1;
            case "NO":
                goto End;
            default:
                Console.WriteLine("Your Choice {0} is invalid.... Please try again", Userdecision2);
                goto Decide1;
        }

        End:
        Console.WriteLine("Thank you for using this application");

    } 




}
   





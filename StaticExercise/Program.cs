//JESUS
namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


                Console.WriteLine("Would you like to convert Farheinheit or celsius");

                var UserInput = Console.ReadLine();
               // while (UserInput != "Farheinheit" || UserInput != "Celsius")
           
                if (UserInput == "Farheinheit")
                {
                    Console.WriteLine("Please input fareinheight amount");
                    var input = double.Parse(Console.ReadLine());

                    var total = TempConverter.FahrenheitToCelsius(input);
                    Console.WriteLine(total);

                }

                else
                {
                    Console.WriteLine("Please enter celsius amount");

                    var celsiusamount = double.Parse(Console.ReadLine());

                    var total = TempConverter.CelsiusToFahrenheit(celsiusamount);
                    Console.WriteLine(total);
                }









            }
    }
    }



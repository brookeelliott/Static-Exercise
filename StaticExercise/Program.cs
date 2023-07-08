namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double cTemp = TempConverter.FahrenheitToCelcius(23.23);
            double fTemp = TempConverter.CelciusToFahrenheit(42.42);

            Console.WriteLine($"{cTemp} degrees C ---- {fTemp} Degrees F");
            Console.WriteLine("We just converted some temp values!! Yay!! Not lets all agree Celcius is better and the US is weird for using F.");
        }
    }
}

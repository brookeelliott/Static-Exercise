using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		//public TempConverter()
		//{
		//}

		public static double FahrenheitToCelcius(double temp)
		{
			return ((temp - 32) * 1.8);
		}

        public static double CelciusToFahrenheit(double temp)
        {
			return ((temp * 1.8) + 32);
        }
    }
}


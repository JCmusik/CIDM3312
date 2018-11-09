using ConverterLib.TempModels;

namespace ConverterLib
{
    public class TempConverter : ITempConversions
    {
        public decimal GetTemp(string type, decimal tempIn)
        {
            switch (type)
            {
                case "Celsius to Fahrenheit":
                    return CelsiusToFahrenheit.Convert(tempIn);
                case "Fahrenheit to Celsius":
                    return FahrenheitToCelsius.Convert(tempIn);
                case "Celsius to Kelvin":
                    return CelsiusToKelvin.Convert(tempIn);
                case "Kelvin to Celsius":
                    return KelvinToCelsius.Convert(tempIn);
                case "Fahrenheit to Kelvin":
                    return FahrenheitToKelvin.Convert(tempIn);
                case "Kelvin to Fahrenheit":
                    return KelvinToFahrenheit.Convert(tempIn);
                default:
                    return tempIn;
            }
        }
    }
}
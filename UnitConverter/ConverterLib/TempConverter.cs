using ConverterLib.TempModels;

namespace ConverterLib
{
    public class TempConverter : ITempConversions
    {
        public decimal GetTemp(string type, decimal tempIn)
        {
            switch (type)
            {
                case "c2f":
                    return CelsiusToFahrenheit.Convert(tempIn);
                case "f2c":
                    return FahrenheitToCelsius.Convert(tempIn);
                case "c2k":
                    return CelsiusToKelvin.Convert(tempIn);
                case "k2c":
                    return KelvinToCelsius.Convert(tempIn);
                case "f2k":
                    return FahrenheitToKelvin.Convert(tempIn);
                case "k2f":
                    return KelvinToFahrenheit.Convert(tempIn);
                default:
                    return tempIn;
            }
        }
    }
}
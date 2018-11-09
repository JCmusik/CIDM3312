namespace ConverterLib.TempModels
{
    public class CelsiusToFahrenheit : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return ((tempIn * 9M) / 5M) + 32;
        }
    }
}
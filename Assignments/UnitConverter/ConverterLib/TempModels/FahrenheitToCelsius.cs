namespace ConverterLib.TempModels
{
    public class FahrenheitToCelsius : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return (tempIn - 32) / 9M * 5M;
        }
    }
}
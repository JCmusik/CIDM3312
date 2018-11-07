namespace ConverterLib.TempModels
{
    public class KelvinToFahrenheit : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn * (9M / 5M) - 459.67M;
        }
    }
}
namespace ConverterLib.TempModels
{
    public class FahrenheitToKelvin : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return (tempIn + 459.67M) * 5M / 9M;
        }
    }
}
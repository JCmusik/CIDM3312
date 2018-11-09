namespace ConverterLib.TempModels
{
    public class CelsiusToKelvin : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn + 273.15M;
        }

    }
}
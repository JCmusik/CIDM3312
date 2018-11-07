namespace ConverterLib.TempModels
{
    public class KelvinToCelsius : ITempConversions
    {
        public decimal GetTemp(decimal tempIn)
        {
            return tempIn - 273.15M;
        }
    }
}
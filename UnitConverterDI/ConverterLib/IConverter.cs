namespace ConverterLib
{
    public interface IConverter
    {
        decimal GetConversion(string type, decimal tempIn);
    }
}
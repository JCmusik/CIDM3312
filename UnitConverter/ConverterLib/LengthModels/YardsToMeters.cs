namespace ConverterLib.LengthModels
{
    public class YardsToMeters : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 0.9144M;
        }
    }
}
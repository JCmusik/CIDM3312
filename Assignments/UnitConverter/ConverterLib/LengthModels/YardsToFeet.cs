namespace ConverterLib.LengthModels
{
    public class YardsToFeet : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 3M;
        }
    }
}
namespace ConverterLib.LengthModels
{
    public class MetersToFeet : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn / 0.3048M;
        }
    }
}
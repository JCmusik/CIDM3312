namespace ConverterLib.LengthModels
{
    public class FeetToMeters : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 3.2808M;
        }
    }
}
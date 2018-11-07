namespace ConverterLib.LengthModels
{
    public class FeetToYards : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 0.3333333333M;
        }
    }
}
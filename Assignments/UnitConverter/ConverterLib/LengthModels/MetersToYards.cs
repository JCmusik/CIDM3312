namespace ConverterLib.LengthModels
{
    public class MetersToYards : ILengthConversions
    {
        public decimal GetLength(decimal lenghtIn)
        {
            return lenghtIn * 1.0936132983M;
        }
    }
}
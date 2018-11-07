namespace ConverterLib.MassModels
{
    public class OunceToPounds : IMassConversions
    {
        public decimal GetMass(decimal massIn)
        {
            return massIn * 0.062500M;
        }
    }
}
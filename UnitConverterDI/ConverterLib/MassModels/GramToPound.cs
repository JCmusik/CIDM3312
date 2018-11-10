namespace ConverterLib.MassModels
{
    public class GramToPound
    {
        public static decimal Convert(decimal massIn)
        {
            return massIn * 0.0022046M;
        }
    }
}
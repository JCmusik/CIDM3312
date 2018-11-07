using Microsoft.EntityFrameworkCore;
using System.Linq;
using ConverterLib.TempModels;
using ConverterLib.MassModels;
using ConverterLib.LengthModels;

namespace UnitConvertWebApp.Models
{
    public interface IDataAccess
    {
        IQueryable<ITempConversions> TempConversions { get; }
        IQueryable<IMassConversions> MassConversions { get; }
        IQueryable<ILengthConversions> LengthConversions { get; }
    }
}
using Microsoft.EntityFrameworkCore;
using ConverterLib;
using System.Linq;

namespace UnitConvertWebApp.Models
{
    public interface IDataAccess
    {
        IQueryable<TempConversions> TempConversions { get; }
        IQueryable<MassConversions> MassConversions { get; }
        IQueryable<LengthConversions> LengthConversions { get; }
    }
}
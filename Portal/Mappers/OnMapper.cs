using System.Collections.Generic;
using System.Linq;
using PioPortal.ViewModels;

namespace PioPortal.Mappers
{
    internal class OnMapper
    {
        internal static On Map(Entities.onquality @from)
        {
            return new OnQuality
                {
                    Comment = @from.comment,
                    Id = @from.onquality_Id,
                    Month = @from.month,
                    Value = @from.value,
                    Year = @from.year
                };
        }

        internal static On Map(Entities.ontime @from)
        {
            return new OnTime
                {
                    Comment = @from.comment,
                    Id = @from.ontime_Id,
                    Month = @from.month,
                    Value = @from.value,
                    Year = @from.year
                };
        }

        internal static List<On> Map(IEnumerable<Entities.onquality> @from)
        {
            return @from.Select(Map).ToList();
        }

        internal static List<On> Map(IEnumerable<Entities.ontime> @from)
        {
            return @from.Select(Map).ToList();
        }
    }
}

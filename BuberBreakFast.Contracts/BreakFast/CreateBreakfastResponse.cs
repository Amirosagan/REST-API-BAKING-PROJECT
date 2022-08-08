using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberBreakFast.Contracts.BreakFast
{
    public record CreateBreakfastResponse
    (
         Guid Id,
         string? Name,
         string? Description,
         DateTime StartDateTime,
         DateTime EndDateTime,
         DateTime LastModifiedDateTime,
         List<string>? savory,
         List<string>? Sweet

    );
}
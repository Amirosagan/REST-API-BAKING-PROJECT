using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberBreakFast.Contracts.BreakFast
{
    public record UpsertBreakfastRequest
    (
         string? Name,
         string? Description,
         DateTime StartDateTime,
         DateTime EndDateTime,
         List<string>? savory,
         List<string>? Sweet

    );
}
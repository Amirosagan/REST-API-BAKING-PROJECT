using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberBreakFast.Contracts.BreakFast;
using BuberBreakFast.Models;

namespace BuberBreakFast.Services.Breakfasts
{
    public interface IBreakfastServices
    {
        void CreateBreakfast(Breakfast breakfast);
        Breakfast GetBreakfast(Guid id);
        void UpsertBreakfast(Breakfast breakfast);
        void DeleteBreakfast(Guid id);
    }
}
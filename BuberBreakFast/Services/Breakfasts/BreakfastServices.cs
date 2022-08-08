using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberBreakFast.Models;

namespace BuberBreakFast.Services.Breakfasts
{
    public class BreakfastServices : IBreakfastServices
    {
        private static readonly Dictionary<Guid , Breakfast> _breakfast = new();

        public void CreateBreakfast(Breakfast breakfast)
        {
            _breakfast.Add(breakfast.Id, breakfast);
        }

        public void DeleteBreakfast(Guid id)
        {
            _breakfast.Remove(id);
        }

        public Breakfast GetBreakfast(Guid id)
        {
            return _breakfast[id];
        }

        public void UpsertBreakfast(Breakfast breakfast)
        {
            _breakfast[breakfast.Id] = breakfast;
        }
    }
}
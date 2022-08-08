using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberBreakFast.Models
{
    public class Breakfast
    {
        public Breakfast(Guid id, DateTime startDateTime, DateTime lastModifiedDateTime, string? description, DateTime endDateTime, string? name, List<string>? savory, List<string>? sweet)
        {
            this.Id = id;
            this.StartDateTime = startDateTime;
            this.LastModifiedDateTime = lastModifiedDateTime;
            Description = description;
            EndDateTime = endDateTime;
            Name = name;
            Savory = savory;
            Sweet = sweet;
        }
        public Guid Id { get; }
        public string? Name { get; }
        public string? Description { get; }
        public DateTime StartDateTime { get; }
        public DateTime EndDateTime { get; }
        public DateTime LastModifiedDateTime { get; }

        public List<String>? Savory { get; }

        public List<String>? Sweet { get; }
    }
}
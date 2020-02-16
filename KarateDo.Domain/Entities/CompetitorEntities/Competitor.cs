using System;

namespace KarateDo.Domain.Entities.CompetitorEntities
{
    public class Competitor : BaseEntity
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int CategoryId { get; set; }

        public int GenderId { get; set; }

        public int ClubId { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}

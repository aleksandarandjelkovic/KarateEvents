using System;

namespace KarateDo.Domain.Entities.CompetitorEntities
{
    public class Competitor : BaseEntity
    {
        public virtual string Name { get; set; }

        public virtual DateTime DateOfBirth { get; set; }

        public virtual int CategoryId { get; set; }

        public virtual int GenderId { get; set; }

        public virtual int ClubId { get; set; }

        public virtual DateTime? DateCreated { get; set; }

        public virtual DateTime? DateUpdated { get; set; }
    }
}

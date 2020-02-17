using KarateDo.Domain.Entities.ClubEntities;
using KarateDo.Domain.Entities.GenderEntities;
using System;

namespace KarateDo.Domain.Entities.CoachEntities
{
    public class Coach : BaseEntity
    {
        public virtual string Name { get; set; }

        public virtual DateTime DateOfBirth { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual CoachType CoachType { get; set; }

        public virtual Club Club { get; set; }

        public virtual DateTime? DateCreated { get; set; }

        public virtual DateTime? DateUpdated { get; set; }
    }
}

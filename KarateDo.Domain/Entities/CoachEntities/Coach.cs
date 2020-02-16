using System;

namespace KarateDo.Domain.Entities.CoachEntities
{
    public class Coach : BaseEntity
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int GenderId { get; set; }

        public int CoachTypeId { get; set; }

        public int ClubId { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}

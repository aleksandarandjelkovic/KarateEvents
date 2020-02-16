using System;

namespace KarateDo.Domain.Entities.ClubEntities
{
    public class Club : BaseEntity
    {
        public string Name { get; set; }

        public string Owner { get; set; }

        public string Pib { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}

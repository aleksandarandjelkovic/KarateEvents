using System;

namespace KarateDo.Domain.Entities.ClubEntities
{
    public class Club : BaseEntity
    {
        public virtual string Name { get; set; }

        public virtual string Owner { get; set; }

        public virtual string Pib { get; set; }

        public virtual string Address { get; set; }

        public virtual string City { get; set; }

        public virtual string Phone { get; set; }

        public virtual DateTime? DateCreated { get; set; }

        public virtual DateTime? DateUpdated { get; set; }
    }
}

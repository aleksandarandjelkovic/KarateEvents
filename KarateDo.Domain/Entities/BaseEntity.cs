using KarateDo.Domain.IEntities;
using System;
using System.Runtime.CompilerServices;

namespace KarateDo.Domain.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public virtual int Id { get; set; }

        private static bool IsTransient(BaseEntity obj)
        {
            return obj != null &&
            Equals(obj.Id, default(int));
        }

        private Type GetUnproxiedType()
        {
            return GetType();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as BaseEntity);
        }

        public virtual bool Equals(BaseEntity other)
        {
            if (other == null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (!IsTransient(this) &&
            !IsTransient(other) &&
            Equals(Id, other.Id))
            {
                var otherType = other.GetUnproxiedType();
                var thisType = GetUnproxiedType();
                return thisType.IsAssignableFrom(otherType) ||
                otherType.IsAssignableFrom(thisType);
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                if (Equals(Id, default(int)))
                    return RuntimeHelpers.GetHashCode(this);

                return Id.GetHashCode();
            }
        }

    }
}

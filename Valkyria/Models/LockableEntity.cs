using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valkyria.Engine.Interfaces;

namespace Valkyria.Engine.Models
{
    public class LockableEntity : VEntity, ILockable
    {
        protected bool m_isLocked;
        protected IList<IKey> m_keys;

        public void Lock(IKey key)
        {
            if (!HasKey(key))
            {
                m_keys.Add(key);
                m_isLocked = true;
            }
        }

        public void Unlock(IKey key)
        {
            if (HasKey(key))
            {
                m_isLocked = false;
            }
        }

        public void Unlock(IEnumerable<IKey> keys)
        {
            if (keys.All(k => HasKey(k)))
            {
                m_isLocked = false;
            }
        }

        public bool IsLocked() => m_isLocked;

        private bool HasKey(IKey key)
        {
            return m_keys.Any(k => k.GetId().Equals(key.GetId()));
        }
    }
}

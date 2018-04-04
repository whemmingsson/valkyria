using System;
using System.Collections.Generic;
using System.Text;

namespace Valkyria.Engine.Interfaces
{
    interface ILockable
    {
        void Lock(IKey key);
        void Unlock(IKey key);
        void Unlock(IEnumerable<IKey> keys);
        bool IsLocked();
    }
}

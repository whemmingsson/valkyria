using System;
using System.Collections.Generic;
using System.Text;
using Valkyria.Engine.Exceptions;
using Valkyria.Engine.Interfaces;

namespace Valkyria.Engine.Models
{
    public class StorageContainer : LockableEntity, ISearchableContainer
    {
        private IList<ILootable> m_inventory;

        public IEnumerable<ILootable> Search()
        {
            if(this.IsLocked())
            {
                throw new EntityIsLockedException();
            }

            var clone = CloneInventory();
            m_inventory.Clear();
            return clone;
        }

        private IList<ILootable> CloneInventory()
        {
            var clone = new List<ILootable>();

            foreach(var lootable in m_inventory)
            {
                clone.Add(lootable);
            }

            return clone;
        }
    }
}

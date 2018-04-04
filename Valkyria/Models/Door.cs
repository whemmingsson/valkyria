using System;
using System.Collections.Generic;
using Valkyria.Engine.Exceptions;
using Valkyria.Engine.Interfaces;

namespace Valkyria.Engine.Models
{
    public class Door : LockableEntity, IOpenable
    {
        private bool m_isOpen;

        private IList<Room> m_rooms;

        public Door()
        {
            m_rooms = new List<Room>();
        }

        public void Link(params Room[] rooms)
        {
            if(rooms.Length < 2)
            {
                throw new ArgumentException("Cannot link this door to fewer than two rooms", "rooms");
            }

            if (rooms.Length > 2)
            {
                throw new ArgumentException("In this version; cannot link this door to more than two rooms", "rooms");
            }

            foreach (var r in rooms)
            {
                m_rooms.Add(r);
            }
        }

        public void Open()
        {
            if (this.IsLocked())
            {
                throw new EntityIsLockedException();
            }

            m_isOpen = true;
        }

        public void Close()
        {
            m_isOpen = false;
        }

        public bool IsOpen() => m_isOpen;                
    }
}

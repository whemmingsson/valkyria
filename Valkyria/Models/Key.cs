using System;
using Valkyria.Engine.Interfaces;

namespace Valkyria.Engine.Models
{
    public class Key : VEntity, IKey
    {
        public Guid GetId()
        {
            return base.Id;
        }
    }
}

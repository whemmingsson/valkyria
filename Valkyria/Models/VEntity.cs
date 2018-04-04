using System;
using System.Collections.Generic;
using System.Text;

namespace Valkyria.Engine.Models
{
    /// <summary>
    /// Base class for all game entities
    /// </summary>
    public abstract class VEntity
    {
        public Guid Id { get; set; }

        public VEntity()
        {
            Id = Guid.NewGuid();
        }

        public VEntity(Guid g)
        {
            Id = g;
        }
    }
}

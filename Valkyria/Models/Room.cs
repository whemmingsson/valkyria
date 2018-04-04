using System.Collections.Generic;
using Valkyria.Engine.Interfaces;

namespace Valkyria.Engine.Models
{
    public class Room : VEntity, IContainer
    {
        private IList<ISearchableContainer> m_containers;
        private IList<Door> m_doors;
    }
}

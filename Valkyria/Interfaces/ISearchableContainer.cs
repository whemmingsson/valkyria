using System;
using System.Collections.Generic;
using System.Text;

namespace Valkyria.Engine.Interfaces
{
    interface ISearchableContainer
    {
        IEnumerable<ILootable> Search();
    }
}

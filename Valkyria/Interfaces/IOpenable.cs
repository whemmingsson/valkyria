using System;
using System.Collections.Generic;
using System.Text;

namespace Valkyria.Engine.Interfaces
{
    interface IOpenable
    {
        void Open();
        void Close();
        bool IsOpen();
    }
}

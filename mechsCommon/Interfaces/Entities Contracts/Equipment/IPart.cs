using System;
using System.Collections.Generic;
using System.Text;

namespace Mechs.Common.Interfaces
{
    public interface IPart : IEntity
    {
        int Damages { get; set; }
        int Mass { get; }
    }
}

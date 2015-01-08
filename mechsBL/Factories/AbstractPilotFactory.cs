using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mechs.Common.Interfaces;

namespace Mechs.BL.Factories
{
    internal abstract class AbstractPilotFactory
    {
        public abstract IPilot CreatePilot();
    }
}

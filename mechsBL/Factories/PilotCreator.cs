using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mechs.Common.Interfaces;
using Mechs.BL.BusinessObjects;

namespace Mechs.BL.Factories
{
    internal class PilotCreator : AbstractPilotFactory
    {
        public override IPilot CreatePilot()
        {
            return new Warrior();
        }
    }
}

// ------------------------------------------------------------------------
// <copyright file="IMech.cs" company="DEP Space">
//     DEP Space. All rights reserved
// </copyright>
// <author>
//     Dmitry Piskun
// </author>
// <summary>
//      Initially created on 16/07/2013
// </summary>
// ------------------------------------------------------------------------

using System.Collections.Generic;

namespace Mechs.Common.Interfaces
{
    public interface IMech : IEntity
    {
        IEnumerable<IWeapon> Weapons { get; }
        IEnumerable<IPart> Parts { get; }
    }
}

// ------------------------------------------------------------------------
// <copyright file="IWarrior.cs" company="DEP Space">
//     DEP Space. All rights reserved
// </copyright>
// <author>
//     Dmitry Piskun
// </author>
// <summary>
//      Initially created on 16/07/2013
// </summary>
// ------------------------------------------------------------------------

namespace Mechs.Common.Interfaces
{
    using System.Collections.Generic;
    using Mechs.Common.Enums;
    using Mechs.Common.Interfaces.Entities_Contracts;

    public interface IPilot : IEntity
    {
        int Rating { get; set; }
        RankType Rank { get; set; }
        TitleType Title { get; set; }
        IEnumerable<ISkill> Skills { get; set; }
    }
}

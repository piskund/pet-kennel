// ------------------------------------------------------------------------
// <copyright file="Warrior.cs" company="DEP Space">
//     DEP Space. All rights reserved
// </copyright>
// <author>
//     Dmitry Piskun
// </author>
// <summary>
//      Initially created on 16/07/2013
// </summary>
// ------------------------------------------------------------------------

using Mechs.Common.Entities;
using Mechs.Common.Interfaces;
using Mechs.Common.Enums;

namespace Mechs.BL.BusinessObjects
{
    /// <summary>
    /// Pilot class
    /// </summary>
    public class Warrior : IPilot
    {
        #region IWarrior Members

        /// <summary>
        /// Pilot's rating
        /// </summary>
        public int Rating
        {
            get;
            set;
        }

        public RankType Rank
        {
            get;
            set;
        }

        public TitleType Title
        {
            get;
            set;
        }

        public Skill Skills
        {
            get;
            set;
        }

        #endregion

        #region IIdentificable Members

        public ulong ID
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            set;
        }

        #endregion


        System.Collections.Generic.IEnumerable<Common.Interfaces.Entities_Contracts.ISkill> IPilot.Skills
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public string EntityID
        {
            get { throw new System.NotImplementedException(); }
        }


        public int HashKey
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}

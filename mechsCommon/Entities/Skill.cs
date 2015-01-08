// ------------------------------------------------------------------------
// <copyright file="Skill.cs" company="DEP Space">
//     DEP Space. All rights reserved
// </copyright>
// <author>
//     Dmitry Piskun
// </author>
// <summary>
//      Initially created on 16/07/2013
// </summary>
// ------------------------------------------------------------------------

namespace Mechs.Common.Entities
{
    using Mechs.Common.Interfaces.Entities_Contracts;

    public struct Skill : ISkill
    {
        public ushort Level { get; set; }

        public string EntityID
        {
            get { throw new System.NotImplementedException(); }
        }

        public string Name
        {
            get { throw new System.NotImplementedException(); }
        }


        public int HashKey
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}

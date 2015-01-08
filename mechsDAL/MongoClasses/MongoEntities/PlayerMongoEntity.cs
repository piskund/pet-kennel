// ------------------------------------------------------------------------
// <copyright file="PlayerEntity.cs" company="DEP Space">
//     DEP Space. All rights reserved
// </copyright>
// <author>
//     Dmitry Piskun
// </author>
// <summary>
//      Initially created on 16/07/2013
// </summary>
// ------------------------------------------------------------------------

using Mechs.Common.Interfaces;
using MechsDAL.MongoClasses;

namespace MechsDAL.Entities
{
    internal class PlayerEntity : MongoEntity, IPlayer
    {
    }
}

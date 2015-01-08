// ------------------------------------------------------------------------
// <copyright file="IMongoEntity.cs" company="DEP Space">
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
using MongoDB.Bson;

namespace MechsDAL.MongoClasses.Interfaces
{
    internal interface IMongoEntity : IEntity
    {
        BsonObjectId Id { get; set; }
    }
}

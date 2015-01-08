// ------------------------------------------------------------------------
// <copyright file="MongoEntity.cs" company="DEP Space">
//     DEP Space. All rights reserved
// </copyright>
// <author>
//     Dmitry Piskun
// </author>
// <summary>
//      Initially created on 16/07/2013
// </summary>
// ------------------------------------------------------------------------

using MechsDAL.MongoClasses.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MechsDAL.MongoClasses
{
    internal class MongoEntity : IMongoEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public BsonObjectId Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the entity identifier.
        /// </summary>
        /// <value>
        /// The entity identifier.
        /// </value>
        [BsonIgnore]
        public string EntityID
        {
            get 
            {
                string entityId = null;

                if (this.Id != null)
                {
                    entityId = this.Id.AsString;
                }

                return entityId;
            }
        }
    }
}

// ------------------------------------------------------------------------
// <copyright file="MongoEntityCollectionWrapper.cs" company="DEP Space">
//     DEP Space. All rights reserved
// </copyright>
// <author>
//     Dmitry Piskun
// </author>
// <summary>
//      Initially created on 11/06/2014
// </summary>
// ------------------------------------------------------------------------

namespace MechsDAL.MongoClasses.MongoWrappers
{
    using System;
    using MechsDAL.MongoClasses.Interfaces;
    using MongoDB.Driver;

    internal class MongoEntityCollectionWrapper<T> where T : IMongoEntity
    {
        public MongoCollection<T> MongoCollection { get; private set; }

        public MongoEntityCollectionWrapper() : 
            this(MechsMongoDbWrapper.MechsMongoDb)
        {
        }

        private MongoEntityCollectionWrapper(MongoDatabase db)
        {
            MongoCollection = db.GetCollection<T>(
                GetCollectionNameByType(typeof(T))
                );
        }

        private static string GetCollectionNameByType(Type entityType)
        {
            var result = entityType.Name.Replace("MongoEntity", "s");

            return result;
        }
    }
}

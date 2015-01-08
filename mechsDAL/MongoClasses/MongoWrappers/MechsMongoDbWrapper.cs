// ------------------------------------------------------------------------
// <copyright file="BaseMongoCollectionWrapper.cs" company="Databrain">
//     Databrain. All rights reserved
// </copyright>
// <author>
//     Dmitry Piskun
// </author>
// <summary>
//      Initially created on 11.06.2014 12:26:17
// </summary>
// ------------------------------------------------------------------------

namespace MechsDAL.MongoClasses.MongoWrappers
{
    using System;
    using MongoDB.Driver;

    /// <summary>
    /// Wrapper for access to mongo collection.
    /// </summary>
    internal static class MechsMongoDbWrapper
    {
        private const string DEFAULT_DB_NAME = "mechs";
        private static readonly string CONNECTION_STRING = "";

        /// <summary>
        /// Our mechs mongo database
        /// </summary>
        internal static MongoDatabase MechsMongoDb
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes the <see cref="MechsMongoDbWrapper"/> class.
        /// </summary>
        static MechsMongoDbWrapper()
        {
            var mongoClient = new MongoClient(MechsMongoDbWrapper.CONNECTION_STRING);
            MechsMongoDb = mongoClient.GetServer().GetDatabase(DEFAULT_DB_NAME);
        }

        /// <summary>
        /// Gets the database by connection string.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        private static MongoDatabase GetDatabase(string connectionString)
        {
            var databaseName = MongoUrl.Create(connectionString).DatabaseName ?? DEFAULT_DB_NAME;
            var mongoClient = new MongoClient(connectionString);
            return mongoClient.GetServer().GetDatabase(databaseName);
        }
    }
}

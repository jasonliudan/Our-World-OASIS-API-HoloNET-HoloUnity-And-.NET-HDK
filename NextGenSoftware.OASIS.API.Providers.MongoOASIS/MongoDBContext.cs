﻿using MongoDB.Driver;
using NextGenSoftware.OASIS.API.Core;
using static NextGenSoftware.OASIS.API.Providers.MongoDBOASIS.MongoDBOASIS;

namespace NextGenSoftware.OASIS.API.Providers.MongoDBOASIS
{
    public class MongoDbContext
    {
        public MongoClient MongoClient { get; set; }
        public IMongoDatabase MongoDB { get; set; }

        public MongoDbContext(string connectionString, string dbName)
        {
            //MongoClient mongoClient = new MongoClient("mongodb+srv://dbadmin:PlRuNP9u4rG2nRdN@oasisapi-oipck.mongodb.net/test?retryWrites=true&w=majority");
            MongoClient = new MongoClient(connectionString);
            MongoDB = MongoClient.GetDatabase(dbName);
            //_mongoDb = mongoClient.GetDatabase("OASISAPI");
        }

        public IMongoCollection<Avatar> Avatar
        {
            get
            {
                return MongoDB.GetCollection<Avatar>("Avatar");
            }
        }

        public IMongoCollection<SearchData> SearchData
        {
            get
            {
                return MongoDB.GetCollection<SearchData>("SearchData");
            }
        }
    }
}

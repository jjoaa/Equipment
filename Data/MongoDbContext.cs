using EP.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EP.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;
        public IMongoCollection<MaintenanceHistory> MaintenanceHistories { get; }

        public MongoDbContext()
        {
            try
            {
                var client = new MongoClient("mongodb+srv://jjoaa7:12rladusdk@cluster0.mongodb.net/?retryWrites=true&w=majority");
                _database = client.GetDatabase("mydb");
                MaintenanceHistories = _database.GetCollection<MaintenanceHistory>("MaintenanceHistories");

                System.Diagnostics.Debug.WriteLine("몽고디비 연결 성공!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MongoDbContext 생성 실패: " + ex.Message);
            }
        }
    }
}
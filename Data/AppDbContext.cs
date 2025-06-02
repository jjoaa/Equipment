using EP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;  // 서버버전 관련



namespace EP.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<MaintenanceHistory> MaintenanceHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connStr = "server=localhost;port=3306;user=root;password=000000;database=weapon_maintenance;";
            options.UseMySql(connStr, ServerVersion.AutoDetect(connStr));
        }
    }
}

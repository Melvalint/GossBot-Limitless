using GossBot.Classic.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace GossBot.Classic.Data.Context.SQLiteContext
{
    public class GossBotSQLiteDbContext : DbContext
    {
        #region DbSets
        public DbSet<RaidAttendanceEntity> RaidAttendances { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<RaidAttendanceEntity>().ToTable("RaidAttendance", "test");
            modelBuilder.Entity<RaidAttendanceEntity>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(e => e.RaidDate).HasDefaultValueSql("CURRENT_TIMESTAMP").HasColumnName("RaidDate");
                entity.Property(e => e.RaiderID).HasColumnName("RaiderID");
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}

using GossBot.Classic.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace GossBot.Classic.Data.Mapper.SQLite
{
    public class RaidAttendanceEntityMapper
    {
        public static void MaptToDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaidAttendanceEntity>().ToTable("RaidAttendance", "test");
            modelBuilder.Entity<RaidAttendanceEntity>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(e => e.RaidDate).HasDefaultValueSql("CURRENT_TIMESTAMP").HasColumnName("RaidDate");
                entity.Property(e => e.RaiderID).HasColumnName("RaiderID");
            });
        }
    }
}

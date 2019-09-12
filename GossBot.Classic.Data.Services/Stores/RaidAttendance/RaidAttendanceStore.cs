using GossBot.Classic.Data.Context.SQLiteContext;
using GossBot.Classic.Data.Models.Entities;
using GossBot.Classic.Data.Stores.Results;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GossBot.Classic.Data.Stores.RaidAttendance
{
    public class RaidAttendanceStore<TContext> : IRaidAttendanceStore where TContext : GossBotSQLiteDbContext
    {
        public TContext Context { get; private set; }

        public RaidAttendanceStore(TContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public bool AutoSaveChanges { get; set; } = true;

        protected DbSet<RaidAttendanceEntity> RaidAttendances => Context.Set<RaidAttendanceEntity>();

        protected Task SaveChanges()
        {
            return AutoSaveChanges ? Context.SaveChangesAsync() : Task.CompletedTask;
        }

        public async Task<GossBotDataResult> AddAbscense(RaidAttendanceEntity abscense)
        {
            Context.Add(abscense);
            await SaveChanges();

            return GossBotDataResult.Success;
        }
    }
}

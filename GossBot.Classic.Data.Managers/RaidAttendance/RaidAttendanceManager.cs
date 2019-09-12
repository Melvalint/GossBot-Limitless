using GossBot.Classic.Data.Models.Entities;
using GossBot.Classic.Data.Stores.RaidAttendance;
using GossBot.Classic.Data.Stores.Results;
using System;
using System.Threading.Tasks;

namespace GossBot.Classic.Data.Managers.RaidAttendance
{
    public class RaidAttendanceManager
    {
        protected internal IRaidAttendanceStore Store { get; private set; }

        public RaidAttendanceManager(IRaidAttendanceStore store)
        {
            Store = store ?? throw new ArgumentNullException(nameof(store));
        }

        public virtual Task<GossBotDataResult> AddAbscense(RaidAttendanceEntity abscense)
        {
            return Store.AddAbsenceAsync(abscense);
        }
    }
}

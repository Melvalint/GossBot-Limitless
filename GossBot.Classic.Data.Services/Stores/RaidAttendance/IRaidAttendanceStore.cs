using GossBot.Classic.Data.Models.Entities;
using GossBot.Classic.Data.Stores.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GossBot.Classic.Data.Stores.RaidAttendance
{
    public interface IRaidAttendanceStore
    {
        Task<GossBotDataResult> AddAbsenceAsync(RaidAttendanceEntity absence);
    }
}

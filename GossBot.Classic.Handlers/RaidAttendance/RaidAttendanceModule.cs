using Discord.Commands;
using Discord.WebSocket;
using GossBot.Classic.Data.Managers.RaidAttendance;
using GossBot.Classic.Data.Stores.RaidAttendance;
using System;
using System.Threading.Tasks;

namespace GossBot.Classic.Handlers.Commands
{
    public class RaidAttendanceModule : ModuleBase<SocketCommandContext>
    {
        private readonly IRaidAttendanceStore _raidAttendanceStore;

        public RaidAttendanceModule(IRaidAttendanceStore raidAttendanceStore)
        {
            _raidAttendanceStore = raidAttendanceStore;
        }

        [Command("absent")]
        [Summary("Marks the current user as absent or the raider who's name is passed")]
        public async Task MarkAbsentAsync([Summary("The (optional) user to get info from")]
        SocketUser user = null)
        {
            var userInfo = user ?? Context.Guild.GetUser(user.Id);
            // TODO: Implement Database call to persist this record.
            var result = await _raidAttendanceStore.AddAbsenceAsync(new Data.Models.Entities.RaidAttendanceEntity() { RaidDate = DateTime.Now, RaiderID = 1 });
            await ReplyAsync($"{result.Succeeded} adding {userInfo.Username}#{userInfo.Discriminator} has been marked as absent.");
        }
    }
}

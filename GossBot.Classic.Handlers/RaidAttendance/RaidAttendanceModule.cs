using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace GossBot.Classic.Handlers.Commands
{
    public class RaidAttendanceModule : ModuleBase<SocketCommandContext>
    {
        [Command("absent")]
        [Summary("Marks the current user as absent or the raider who's name is passed")]
        public async Task MarkAbsentAsync([Summary("The (optional) user to get info from")]
        SocketUser user = null)
        {
            var userInfo = user ?? Context.Guild.GetUser(Context.User.Id);
            // TODO: Implement Database call to persist this record.
            await ReplyAsync($"{userInfo.Username}#{userInfo.Discriminator} has been marked as absent.");
        }
    }
}

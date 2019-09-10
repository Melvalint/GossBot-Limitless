using System;
using System.Threading.Tasks;

namespace GossBot.Classic.Limitless
{
    public class GossBot
    {
        public static void Main(string[] args)
            => new GossBot().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {

        }
    }
}

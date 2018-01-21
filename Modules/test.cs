using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kallen.Modules
{
    public class test : ModuleBase<SocketCommandContext>

    {

        [Command("Kallen")]
        public async Task Kallen()
        {

            await Context.Channel.SendMessageAsync("!We judge ourselves by what we feel capable of doing, while others judge us by what we have already done");
        }

        [Command("Motto")]
        public async Task Motto()
        {

            await Context.Channel.SendMessageAsync("!The road we must walk is uphill ... That's why we are destined to go high!");
        }

        [Command("anchorman")]
        public async Task anchorman()
        {

            await Context.Channel.SendMessageAsync("!**Vivi con classe Nomen Vision!!**");
        }

        [Command("shepard")]
        public async Task shepard()
        {

            await Context.Channel.SendMessageAsync("!Please, dear God, don't let me fuck up.");
        }

    }
}

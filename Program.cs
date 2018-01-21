using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace Kallen
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();
            new CommandHandler(_client);

            await _client.LoginAsync(TokenType.Bot, "NDA0NjA4NzY0ODM1MjY2NTYw.DUYXZw.i6sjnhDbhW1_jO6gC8zXU4NV5mY");

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }

    }
}

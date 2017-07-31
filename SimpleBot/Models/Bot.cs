using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Telegram.Bot;
using SimpleBot.Models.Commands;

namespace SimpleBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> commandList;

        public static IReadOnlyList<Command> Commands => commandList.AsReadOnly();

        public static async Task<TelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            commandList = new List<Command>
            {
                new HelloCommand()
            };
            //TODO: Add more commands

            client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await client.SetWebhookAsync(hook);

            return client;
        }
    }
}
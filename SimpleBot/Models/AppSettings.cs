using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotapp.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "John_Clucker_bot";

        public static string Key { get; set; } = "403416362:AAHmgIGqzQTQX1nN7QJSurQgOpWGKxzxW1k";
    }
}
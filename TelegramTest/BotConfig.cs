using System.Collections.Specialized;
using System.Configuration;

namespace BotLogic
{
    public static class BotConfig
    {
        private static readonly NameValueCollection Appsettings = ConfigurationManager.AppSettings;

        public static string Token => Appsettings["213196674:AAEFdKzcvd_Ln-2VpwKKzQ4ASE0oP6osvb8"];

        public static string WebHookUrl => Appsettings["https://telegramtb.azurewebsites.net:8443/api/message/" + Token];
    }
}

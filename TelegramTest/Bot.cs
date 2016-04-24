using Telegram.Bot;

namespace BotLogic
{
    public static class Bot
    {
        private static Api _bot;

        public static Api Get()
        {
            if (_bot != null)
                return _bot;
            _bot = new Api(BotConfig.Token);
            _bot.SetWebhook(BotConfig.WebHookUrl).Wait();
            return _bot;
        }
    }
}
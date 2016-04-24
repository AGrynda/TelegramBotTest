using Telegram.Bot;
using Telegram.Bot.Types;

namespace BotLogic
{
    public class Handler
    {
        private readonly Api _bot;

        public Handler()
        {
            _bot = Bot.Get();
        }

        public async void Handle(Message message)
        {
            await _bot.SendTextMessage(message.Chat.Id, $"Hi {message.Chat.FirstName}");
        }
    }
}
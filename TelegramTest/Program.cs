using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace TelegramTest
{
    class Program
    {
        static void Main(string[] args)
        {
            testApi();
            Console.ReadKey();
        }

        static async void testApi()
        {
            var bot = new Telegram.Bot.Api("213196674:AAEFdKzcvd_Ln-2VpwKKzQ4ASE0oP6osvb8");
            var me = await bot.GetMe();
            var updates = await bot.GetUpdates();
            var firstOrDefault = updates.FirstOrDefault();
            var id = firstOrDefault.Message.Chat.Id;
            bot.MessageReceived += (sender, args) => { bot.SendTextMessage(id, "Hi"); };
            Console.WriteLine("Hello my name is " + me.FirstName);
        }

    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Cybersecurity Awareness Bot";
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Play voice (optional - remove if you don't have AudioPlayer)
        // AudioPlayer.PlayGreeting();

        // Show logo
        UIHelper.ShowLogo();

        // Start chatbot
        Chatbot bot = new Chatbot();
        bot.Start();

        // No need for the extra while loop - the menu handles everything
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Title = "Cybersecurity Awareness Bot";
        Console.OutputEncoding = System.Text.Encoding.UTF8;

    
        UIHelper.ShowLogo();

        
        Chatbot bot = new Chatbot();
        bot.Start();

    
    }
}

using System;
using System.Media;
using System.Speech.Synthesis;


namespace CyberSecurityChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Play recorded greeting (make sure greeting.wav is in your project folder)
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();

            // ASCII art logo
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===================================");
            Console.WriteLine("     Cybersecurity Awareness Bot   ");
            Console.WriteLine("===================================\n");
            Console.ResetColor();

            // Ask for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Spoken greeting
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Male);
            synth.Speak($"Hello {name}, welcome to the Cybersecurity Awareness Bot!");

            // Chat loop
            ChatBot bot = new ChatBot(name);
            bool running = true;
            while (running)
            {
                Console.Write($"{name}: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please type something.");
                    continue;
                }
                if (input.ToLower() == "exit")
                {
                    running = false;
                    Console.WriteLine("Goodbye, stay safe online!");
                }
                else
                {
                    string response = bot.Respond(input);

                    //Highlight bot response in green

                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("Bot: " + response);
                    Console.ResetColor();

                    synth.Speak(response); // speak the response aloud
                }


            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    public class ChatBot
    {
        private string userName;

        public ChatBot(string name)
        {
            userName = name;
        }

        public string Respond(string input)
        {
            input = input.ToLower();
            switch (input)
            {
                case "how are you?":
                    return "I’m just code, but I’m running smoothly!";
                case "what's your purpose?":
                    return "I help you learn about online safety.";
                case "what can i ask you about?":
                    return "You can ask me about password safety, phishing, or safe browsing.";
                case "password safety":
                    return "Always use strong, unique passwords and enable two-factor authentication.";
                case "phishing":
                    return "Don’t click suspicious links or share personal info via email.";
                case "safe browsing":
                    return "Keep your browser updated and avoid unsafe websites.";
                default:
                    return "I didn’t quite understand that. Could you rephrase?";
            }
        }
    }
}

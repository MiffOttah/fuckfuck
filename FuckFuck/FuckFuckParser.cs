using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckFuck
{
    public static class FuckFuckParser
    {
        public static Command[] ParseProgram(string program)
        {
            const string WORDS_CAN_CONTAIN = "abcdefghijklmnopqrstuvwxyz";

            var words = new List<string>();
            var currentWord = new StringBuilder();
            
            foreach (char ch in (program + "\0").Select(char.ToLowerInvariant))
            {
                if (WORDS_CAN_CONTAIN.IndexOf(ch) == -1)
                {
                    if (currentWord.Length > 0)
                    {
                        words.Add(currentWord.ToString());
                        currentWord.Clear();
                    }
                }
                else
                {
                    currentWord.Append(ch);
                }
            }

            return words.Select(WordToCommand).Where(c => c != 0).ToArray();
        }

        private static Command WordToCommand(string word)
        {
            switch (word)
            {
                case "ass": return Command.IncrementPointer;
                case "bitch": return Command.DecrementPointer;
                case "cunt": return Command.IncrementData;
                case "damn": return Command.DecrementData;
                case "dick": return Command.Output;
                case "fuck": return Command.Input;
                case "shit": return Command.BeginLoop;
                case "twat": return Command.EndLoop;
                default: return 0;
            }
        }
    }
}

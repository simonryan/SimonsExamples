using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyKatas
{
    public class TitleCase
    {
        private static List<string> _lowerCaseWords = new List<string>
            {
                "the",
                "to",
                "in",
                "with",
                "and",
                "but",
                "or"
            };

        public static string TitleCaseSentence(string sentence)
        {
            // split string by space
            var words = sentence.Split(' ');

            if (words.Length > 0)
            {
                //capitalise first word
                words[0] = Capitalise(words[0]);
                //capitalise last word
                words[words.Length - 1] = Capitalise(words[words.Length - 1]);
                // for each word [1] to last-1
                for (var i = 1; i < words.Length - 1; i++)
                {
                    if (_lowerCaseWords.Contains(words[i].ToLower()))
                    {
                        words[i] = Lowercase(words[i]);
                    }
                    else
                    {
                        words[i] = Capitalise(words[i]);
                    }
                }
                // if word in list then lowercase
                // if not then capitalise

            }
            return string.Join(" ", words);
        }

        private static string Capitalise(string s)
        {
            s = Lowercase(s);
            s = s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1);
            return s;
        }

        private static string Lowercase(string s)
        {
            return s.ToLower();
        }
    }
}

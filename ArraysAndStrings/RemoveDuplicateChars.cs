using System.Text;

namespace ArraysAndStrings
{
    public static class RemoveDuplicateChars
    {
        public static string RemoveDuplicates1(string s)
        {
            var sb = new StringBuilder();
            if (s.Length > 1)
            {
                var exists = new bool[256];
                var str = s.ToCharArray();

                for (var i = 0; i < str.Length; i++)
                {
                    if (!exists[str[i]])
                    {
                        sb.Append(str[i]);
                        exists[str[i]] = true;
                    }
                }
            }
            return sb.ToString();
        }
    }
}

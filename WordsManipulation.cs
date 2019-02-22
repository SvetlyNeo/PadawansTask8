using System.Text;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }
            if (text.Length == 0)
            {
                throw new ArgumentException();
            }
            StringBuilder sb = new StringBuilder();
            var words = text.Split(new[] { ' ', '.', ',', '!', '?', '-', ':', ';' });
            foreach (var word in words)
            {
                if (sb.ToString().Contains(word))
                {
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(word.Trim() + " ");
                }
            }
            text = sb.ToString().Substring(0, sb.Length - 1);
        }
    }
}
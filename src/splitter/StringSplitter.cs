using System;
using System.Collections.Generic;
using System.Linq;

namespace Mcastrobruno.Splitter
{
    public class StringSplitter
    {
        public string Split(string text, int length)
        {
            //Split text into words
            string[] words = text.Split(' ');

            List<string> lines = new List<string>();
            int lineNumber = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (lines.Count < lineNumber + 1)
                    lines.Add(words[i]);
                else if ((lines[lineNumber] + ' ' + words[i]).Length < length)
                    lines[lineNumber] += ' ' + words[i];
                else
                {
                    lineNumber++;
                    lines.Add(words[i]);
                }
            }

            return string.Join(Environment.NewLine, lines);
        }
    }
}

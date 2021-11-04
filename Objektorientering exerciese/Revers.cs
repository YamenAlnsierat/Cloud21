using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering_exerciese
{
    internal class Revers
    {
        private static string text;

        public static string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
        public static string Reverse
        {
            get
            {
                return GetReverse(text);
            }
            set
            {
                text = GetReverse(value);
            }
        }

        private static string GetReverse(string text)
        {
            string reverse = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse = reverse + text[i];
            }
            return reverse;
        }
    }
}

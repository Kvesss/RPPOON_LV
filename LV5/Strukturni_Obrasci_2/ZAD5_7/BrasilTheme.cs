using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    class BrasilTheme : ITheme
    {
        public string GetFooter(int width)
        {
            return new string('_', width);
        }

        public string GetHeader(int width)
        {
            return new string('+', width);
        }

        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }

        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}

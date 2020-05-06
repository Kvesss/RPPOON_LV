using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    class MagentaWhiteTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public string GetHeader(int width)
        {
            return new string('°', width);
        }
        public string GetFooter(int width)
        {
            return new string('°', width);
        }
    }
}

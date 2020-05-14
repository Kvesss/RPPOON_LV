﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    class LightTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public string GetHeader(int width)
        {
            return new string('<', width);
        }
        public string GetFooter(int width)
        {
            return new string('>', width);
        }
    }
}
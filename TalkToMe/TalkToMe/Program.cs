﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkToMe
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy()
            {
                Height = 74,
                Name = "Adam"
            };
            tallGuy.TalkAboutYourself();
        }
    }
}

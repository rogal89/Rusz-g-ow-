using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkToMe
{
    class TallGuy
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            Console.WriteLine("Nazywam się " + Name + " i mam " + Height + " wzrostu");
        }
    }
}

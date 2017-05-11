using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkToMe
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public string FunnyThingHave
        {
            get { return "duże buty"; }
        }
        public void Honk()
        {
            Console.WriteLine("Tut tuuuuut!");
        }

        public void TalkAboutYourself()
        {
            Console.WriteLine("Nazywam się " + Name + " i mam " + Height + " wzrostu");
        }
    }
}

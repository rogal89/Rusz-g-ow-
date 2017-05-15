using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkToMe
{
    class FunnyFunny: IClown
    {
        protected string funnyThingIHave;
        public string FunnyThingIHave
        {
            get { return "Cześć dzieciaki! Mam " + funnyThingIHave; }
        }
 
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}

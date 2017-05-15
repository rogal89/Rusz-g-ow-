using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkToMe
{
    class ScaryScary: FunnyFunny, IScaryClown
    {
        public string ScaryThingIHave
        {
            get { return "Mam " + numberOfScaryThings + " pająków"; }
        }
        private int numberOfScaryThings;

        public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
            :base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        public void ScareLittleChildren()
        {
            Console.WriteLine("Nie możesz mieć mojego " + base.funnyThingIHave);
        }
    }
}

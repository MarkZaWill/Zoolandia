using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Tiger : Animal
    {
        public string food { get; set; }
        public int Cuteness { get; set; }
        public string Color = "stripy";
        public string Location = "South Asia";
        public string Noise = "Meow";
        public string Claws = "So Spiky";
        public override string Transportation()
        {
            return "stalks";
        }
    }
}

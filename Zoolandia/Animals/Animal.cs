using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public virtual string Name { get; set; }
        public virtual string Transportation()
        {
            return "walks";
        }
    }
}

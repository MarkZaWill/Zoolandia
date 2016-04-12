using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animal
{
    interface IWinged
    {
        bool IsWinged { get; set; }
        bool CanFly { get; set; }
    }
}

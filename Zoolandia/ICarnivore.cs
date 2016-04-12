using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animal
{
    interface ICarnivore
    {
         bool EatsMeat { get; set; }
         string IdealMeal { get; set; }
    }
}

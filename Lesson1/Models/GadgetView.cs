using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1.Models
{
    public class GadgetView
    {
        public int Id { get; set; }
        public string  Type { get; set; }
        public string Firm { get; set; }
        public string Name { get; set; }

        public double Processor_freq { get; set; } 

        public int Operative_memory { get; set; }

        public int Price { get; set; }
    }
}

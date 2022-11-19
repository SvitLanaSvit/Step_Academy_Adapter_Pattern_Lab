using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Adapter_Pattern_1
{
    public class RoundHole //Client
    {
        public int Radius { get; init; }
        public bool fits(RoundPeg rounrPeg)
        {
            return Radius >= rounrPeg.Radius;
        }
    }
}
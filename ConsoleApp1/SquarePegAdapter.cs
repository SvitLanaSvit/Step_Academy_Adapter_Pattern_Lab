using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Adapter_Pattern_1
{
    public class SquarePegAdapter : RoundPeg //Adapter
    {
        private SquarePeg squarePeg;

        public SquarePegAdapter(SquarePeg squarePeg)
        {
            this.squarePeg = squarePeg;
            Radius = squarePeg.Width * Math.Sqrt(2) / 2;
        }
    }
}
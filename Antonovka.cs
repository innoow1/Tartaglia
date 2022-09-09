using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tartaglia
{
    class Antonovka : Apple
    {
        public Antonovka (double age, string type) : base(age, type)
        {

        }
        public new void Grow()
        {
            Age *= 1.5;
        }
    }
}

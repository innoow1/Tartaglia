using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tartaglia
{
    class Alyonushka : Pear
    {
        public Alyonushka(double age, string type) : base(age, type)
        {
        }
        public override void Grow()
        {
            Age += 4;
        }
    }
}

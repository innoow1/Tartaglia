using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tartaglia
{
    class Apple : Tree
    {
        public Apple(double age, string type) : base(age, type)
        {
        }
        public override void Grow()
        {
            Age += 1;
        }
    }
}

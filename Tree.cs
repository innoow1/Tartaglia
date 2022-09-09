using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tartaglia
{
    abstract class Tree
    {
        private double age;
        public double Age 
        {
            get => age;
            protected set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }
        public string Type { get; private set; }

        public Tree(double age, string type)
        {
            Age = age;
            Type = type;
        }
        public abstract void Grow();
        
    }
}

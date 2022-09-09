using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tartaglia
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree AppleTree = new Apple(13, "Яблоня");
            global::System.Console.WriteLine(AppleTree.Age);
            AppleTree.Grow();
            global::System.Console.WriteLine(AppleTree.Age);

            Tree PearTree = new Pear(-12, "Груша");
            global::System.Console.WriteLine(PearTree.Age);
            PearTree.Grow();
            global::System.Console.WriteLine(PearTree.Age);

            Tree antonovka = new Antonovka(5, "Антоновка в Tree");
            Console.WriteLine(antonovka.Age);
            antonovka.Grow();
            Console.WriteLine(antonovka.Age);

            Antonovka antonovka1 = new Antonovka(5, "Антоновка в Antonovka");
            Console.WriteLine(antonovka1.Age);
            antonovka1.Grow();
            Console.WriteLine(antonovka1.Age);

            global::System.Console.WriteLine();
            Console.ReadKey();
        }
    }
    
}

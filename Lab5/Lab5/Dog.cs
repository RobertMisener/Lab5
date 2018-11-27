using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doggie
{
    class Dog
    {
        public string Name { get; set; }

        //5)
        public void bark()
        {

          Console.WriteLine("{0} is Barking...", Name);

        } 

        //6)
        public void doTrick(string trickName)
        {
            Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", Name, trickName);
        }
        // Add doTrick() method
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandstructs
{
    internal class Dude
    {
        public string name;
        public int exp = 0;

        //default
        public Dude()
        {
            // this.name = "Not assigned";
            Reset();
        }

        //constructor
        public Dude(string name)
        {
            this.name = name;

        }
        //class method
        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Dude: " + this.name + " - " + this.exp + " EXP");
        }

        private void Reset()
        {
            this.name = "Not assgined";
            this.exp = 0;
        }
    }
}

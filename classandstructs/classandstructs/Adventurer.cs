using System;

public class Adventurer
{

        public string name;
        public int exp = 0;

        //default
        public Adventurer()
        {
            // this.name = "Not assigned";
            Reset();
        }

        //constructor
        public Adventurer(string name)
        {
            this.name = name;

        }
        //class method
        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Adventurer: " + this.name + " - " + this.exp + " EXP");
        }

        private void Reset()
        {
            this.name = "Not assgined";
            this.exp = 0;
        }

    
}

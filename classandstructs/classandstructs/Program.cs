namespace classandstructs
{
    public class Character
    {
        public string name;
        public int exp = 0;

        //default
        public Character()
        {
          // this.name = "Not assigned";
            Reset();
        }

        //constructor
        public Character(string name)
        {
            this.name = name;
            
        }
        //class method
        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
        }

        private void Reset() { 
          this.name = "Not assgined";
            this.exp = 0;
         }
       
    }

    public class Paladin : Character
    {
        public Weapon weapon;
        public Paladin(string name) : base(name)
        {
        }

        public Paladin(string name, Weapon weapon):base(name) { 
            this.weapon = weapon;
            
        }
        public override void PrintStatsInfo() {
            Console.WriteLine("Hail " + this.name + " - " + this.weapon.name + "!"); 
        }
    }
    public struct Weapon
    {
        public string name;
        public int damage;

        public Weapon(string name, int damage) { 
            this.name = name;
            this.damage = damage;
        }
        public void PrintWeaponStats() {
            Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG" );
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");

            Character hero = new Character();
            //Console.WriteLine("Hero: " + hero.name + " - " + hero.exp + " EXP");
            hero.PrintStatsInfo();


            Character heroine = new Character("Agatha");
            //Console.WriteLine("Hero: " + heroine.name + " - " + heroine.exp + " EXP");
            heroine.PrintStatsInfo();

            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.PrintWeaponStats();

            //Tesing reference type
            Character villian = hero;

            hero.PrintStatsInfo();
            villian.PrintStatsInfo();

            villian.name = "Sir Kane the Brave";
            
            hero.PrintStatsInfo();
            villian.PrintStatsInfo();


            //Testing value type
            Weapon warBow = huntingBow;

            huntingBow .PrintWeaponStats();
            warBow .PrintWeaponStats();

            warBow.name = "War Bow";
            warBow.damage = 155;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();


            //hero.Reset();

            //Experimenting with Inheritance
           // Paladin knight = new Paladin("Sir Arthur");
           Paladin knight=new Paladin("Sir Arthur",huntingBow);
           knight.PrintStatsInfo();

            //Testing external files
            Adventurer mike = new Adventurer("Mike");
            mike.PrintStatsInfo();

            Dude dave = new Dude("Dave");
            dave.PrintStatsInfo();
        }
    }
}

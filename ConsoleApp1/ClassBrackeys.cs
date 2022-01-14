using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class Wizard 
    {
        // Access Modifier
        //public    means that we can access it form outside of the class
        //private   means that we can not access it from outside of the class
        // if we don't write public in front of variable - by default it will be private
        // Fields is best practice to keep them private
        public string name;                 
        public string favoriteSpell;        
        private int spellSlots;
        float experience;       // same as private

        public static int Count;    // we create a static int to count the wizard we created

        public Wizard(string _name, string _favoriteSpell) //creating a constructor
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experience = 0f;
            Count++;
        }

        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
                experience += 0.3f;
            }
            else
            {
                Console.WriteLine(name + " is out of spell slots");
            }           
        }
        public void Meditate()
        {
            Console.WriteLine(name+ " meditate to regain Spell Slots.");
            spellSlots = 2;
        }
        public static void Wizard01()
        {
            Wizard wizard01 = new Wizard("Spider Hopper", "Unexpecto Patronum");
            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.Meditate();
            Console.WriteLine($"{wizard01.name} gained {wizard01.experience} experience");
            Console.WriteLine();
        }
        public static void Wizard02()
        {
            Wizard wizard02 = new Wizard("Glindalf Merlinson", "Ablubu");
            wizard02.CastSpell();
            wizard02.CastSpell();
            
            wizard02.Meditate();
            wizard02.CastSpell();
            wizard02.CastSpell();
            Console.WriteLine($"{wizard02.name} gained {wizard02.experience} experience");
        }

        public static void WizardsRunExample()
        {
            Wizard01();
            Wizard02();
            Console.WriteLine();
            Console.WriteLine("There are " + Wizard.Count + " wizards created so far");
        }
    }

}

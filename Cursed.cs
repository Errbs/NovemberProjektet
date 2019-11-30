using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovProj
{
    class Cursed : Item
    {
        static Random typeOfItem = new Random(); // A random used to randomize the cursed item type.
        protected List<string> cursedItems = new List<string>() {"Pendant", "Book", "Glasses" }; // List of types of cursed items, this could be developed into creating multiple subclasses to Cursed and randomize from an Cursed List instead.
        protected int listIndex; // Int used as an idex in the list.

        public string CursedItemName() //This method is supposed to decide what type of cursed item it is and set the name, for it as well as returning the name.
        {
            listIndex = typeOfItem.Next(cursedItems.Count); // The index is a randomized number from the lenght of the cursedItems list.
            name = "Cursed " + cursedItems[listIndex]; // Sets the name to Cursed + the type of item randomized from the cursedItems list.
            return name; //returns name
        }

        public override string GetInfo() // Overrides the virtual GetInfo method from the parent class Item. 
        {
            return name + ": is an mysterious cursed item and will punish you whenever you are in contact with it."; // Rrturns the name as well as the info. A development of this could be to create a method with a list of different info about the different types of items and that you depending on what type of cursed item access a certain list index of effects and write that.
        }

        public override void Use(Character target) // Applies different effects on the target, depending on what type of cursed item the item is.
        {
            if(name == "Cursed " + cursedItems[0])
            {
                target.ModifyHp(-4);
            }
            else if(name == "Cursed " + cursedItems[1])
            {
                target.ModifyHp(-2);
            }
            else if(name == "Cursed " + cursedItems[2])
            {
                target.ModifyHp(-5);
            }
        }


    }
}

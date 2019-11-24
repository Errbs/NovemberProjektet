using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovProj
{
    class Cursed : Item
    {
        static Random typeOfItem = new Random();
        protected List<string> cursedItems = new List<string>() {"Pendant", "Book", "Glasses" };
        protected int listIndex;

        public void RandomizeItemType()
        {
            listIndex = typeOfItem.Next(cursedItems.Count);
            name = "Cursed " + cursedItems[listIndex];
        }

        public override string GetInfo()
        {
            return name + ": is an mysterious cursed item and will punish you whenever you are in contact with it.";
        }

        public override void Use(Character target)
        {
            
        }


    }
}

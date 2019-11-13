using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovProj
{
    class Inventory
    {
        private List<Item> items;

        public void Add(Item item)
        {
            items.Add(item); //adds an instance(?) of class Item
        }
        public void Remove(int n)
        {
            items.Remove(items[n]); //removes the item with index n in the items list
        }
       
        public string GetItemInfo(int n)
        {
            if (n != 0 || n < 0 && n < items.Count)
            {
               return "Item doesn't exist!";
            }
            else
            {
                return items[n].GetInfo(); //Returns the item with index n in the item lists GetInfo method
            }
        }
       
        public void UseItem(int n, Character c)
        {
            if (n!= 0||n<0 && n < items.Count)
            {
                Console.WriteLine("Item doesn't exist!");
            }
            else
            {
               Remove(n);
            }
        }
        //UseItem 
        public int GetLenght()
        {
            return items.Count();
        }
    }
}

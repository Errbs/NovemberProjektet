using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovProj
{
    class Inventory
    {
        private List<Item> items = new List<Item>(); // Adds new List <Item> after to create an instance of the class, so that the class methods can be used.

        public void Add(Item item) // Add is used to add an item to the list items
        {
            items.Add(item); //adds an item to the itemlist
        }

        public void Remove(int n) // Remove is used to remove an item from the list items
        {
            items.Remove(items[n]); //removes the item with index n in the items list
        }
       
        public string GetItemInfo(int n) // GetItemInfo is used to return the info of an item with the index n in the list items
        {
            if (n != 0 || n < 0 && n < items.Count) // If the value of n isn't equal to the value 0 or below that value and less than the value of the list items lenght return the message below.
            {
               return "Item doesn't exist!";
            }
            else
            {
                return items[n].GetInfo(); //Returns the item with index n in the item lists GetInfo method
            }
        }
       
        public void UseItem(int n, Character c) // UseItem is used to use items in the characters inventory.
        {
            if (n!= 0||n<0 && n < items.Count) // If the value of n isn't equal to the value 0 or below that value and less than the value of the list items lenght it writes out the message below.
            {
                Console.WriteLine("Item doesn't exist!"); 
            }
            else
            {
                c.UseItem(n); // Uses the parameter c's UseItem method for item with index n. *!!! however this might weirdly loop since they point to each other and I have to test it !!!*
                Remove(n); // Runs Remove method for item with index n in list items.
            }
        }
        
        public int GetLenght() // GetLenght returns an int representing how many items are in the list items
        {
            return items.Count(); // Returns the lenght of the list items.
        }
    }
}

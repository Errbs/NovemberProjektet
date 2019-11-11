using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovProj
{
    class Character
    {
        protected string name;
        protected Inventory inventory;
        protected int hp;
        protected int mp;
        protected int strenght;
        protected int x;
        protected int y;
       

        public void AddToInventory(Item item)
        {
            inventory.Add(item);
        }
        public void RemoveFromInventory(int n)
        {
            inventory.Remove(n);
        }
        public void UseItem(int n, Character target)
        {
            inventory.UseItem(n, target);
        }
        public void UseItem(int n)
        {
            inventory.UseItem(n, this);
        }
        
        public int GetInventoryLenght()
        {
           return inventory.GetLenght();
        }
        /*public string GetItemInfo(int n)
        {
           return inventory.GetItemInfo(n);
        }
        NEED TO COMMENT TO TEST CODE
       */
        public void Move(int xMove, int yMove)
        {
            
            x += xMove;
            y += yMove;
            
           // The method takes input in form of ints from main and adds those values to x and/ or y.
        }
        public void SetPosition(int xPos, int yPos)
        {
            xPos = x;
            yPos = y;
       
        }
        public int GetX()
        {
            Console.WriteLine(x);
            return x;
        }
        public int GetY()
        {
            Console.WriteLine(y);
            return y;
        }
        public int GetHp()
        {
            return hp;
        }
        public int ModifyHp(int amount)
        {
            return amount;
        }
        public void Attack(Character target)
        {

        }
    }
}

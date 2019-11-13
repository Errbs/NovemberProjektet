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
        protected int hp = 10;
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
        /*
        public string GetItemInfo(int n)
        {
           return inventory.GetItemInfo(n); // is not a string because it is a "class" list over Item, it will most likely work once I've added subclasses for Item.
        }
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
            Console.WriteLine("Player Position: " + x + ", " + y);
                   
        }
        //I don't know why this method would be useful but it is supposed to set the position of the player.
        public int GetX()
        {
            return x;
        }
        //Getx returns x
        public int GetY()
        {
            return y;
        }
        //GetY returns y
        public int GetHp()
        {
            return hp;
        }
        //GetHp returns hp
        public int ModifyHp(int amount)
        {
           return hp += amount; 
            
        }
        //ModifyHp adds parameter amount to hp and returns it 
        public void Attack(Character target)
        {

        }
    }
}

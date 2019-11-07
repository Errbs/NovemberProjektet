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
        protected int x = 0;
        protected int y = 0;

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

        }
        public string GetItemInfo(int n)
        {
            inventory.GetItemInfo(n);
        }
        public void Move(int xMove, int yMove)
        {
            if (xMove>x||xMove<x)
            {
               
                x = xMove;
            }
            /*else if (xMove < x)
            {
                x = xMove;
            }
            */
            if (yMove>y|| yMove < y)
            {
                y = yMove;
            }
           /* else if (yMove < y)
            {
                y = yMove;
            }
            */
            // testing if it would work
        }
        public void SetPosition(int xPos, int yPos)
        {
            // do later
       
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public int GetHp()
        {

        }
        public int ModifyHp(int amount)
        {

        }
        public void Attack(Character target)
        {

        }
    }
}

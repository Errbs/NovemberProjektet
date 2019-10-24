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

        }
        public void RemoveFromInventory(int n)
        {

        }
        public void UseItem(int n, Character target)
        {

        }
        public void UseItem(int n)
        {

        }
        public int GetInventoryLenght()
        {

        }
        public string GetItemInfo(int n)
        {

        }
        public void Move(int xMove, int yMove)
        {

        }
        public void SetPosition(int xPos, int yPos)
        {

        }
        public int GetX()
        {

        }
        public int GetY()
        {

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

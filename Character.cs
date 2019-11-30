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
        protected Inventory inventory = new Inventory(); // Adds new Inventory after to create an instance of the class, so that the methods of the class can be used.
        protected int hp = 10;
        protected int mp; // I have no idea what this variable is supposed to be used for?? It's never explained in the instructions.
        protected int strenght; 
        protected int x;
        protected int y;
       

        public void AddToInventory(Item item) // This method calls upon the Add method from the Inventory class and runs that code.
        {
            inventory.Add(item);
            
        }
        public void RemoveFromInventory(int n) // This method calls upon the Remove method from the Inventory class and runs that code.
        {
            inventory.Remove(n);
        }
        public void UseItem(int n, Character target) // This method calls upon the UseItem method from the Inventory class and runs that code. This one is used to use the items on other characters.
        {
            inventory.UseItem(n, target);
        }
        public void UseItem(int n) // This method calls upon the UseItem method from the Inventory class and runs that code. This one is used to use the items on the character.
        {
            inventory.UseItem(n, this);
        }
        
        public int GetInventoryLenght() // This method calls upon the GetInventory method from the Inventory class and runs that code.
        {
           return inventory.GetLenght();
        }
       
        public string GetItemInfo(int n) // This method returns information from inventorys GetItemInfo for item n
        {
           return inventory.GetItemInfo(n);
        }
         
        public void Move(int xMove, int yMove)
        {
            
            x += xMove;
            y += yMove;
            
           // The method takes input in form of ints from main and adds those values to x and/ or y.
        }
        public void SetPosition(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
                               
        }
        //The values of x and y is equal to the parameters xPos, yPos taken from the main code.
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

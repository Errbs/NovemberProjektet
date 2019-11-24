using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Character test = new Character(); // Creates an instance of the class Character.
                        
            bool movement = true; // Bool used to loop the code for a characters movement

            Item potion = new Healthpotion(); // Creates an instance of the Item subclass Healthpotion

            

                                    
            Console.WriteLine(potion.GetInfo()); // Writes out info from the instance potions GetInfo method.
            potion.Use(test); // Applies the effects of the item onto the Character instance test.
            Console.WriteLine("Current HP: " + test.GetHp()); // Displays the new HP
                       
          
            while (movement == true)
            {
                int isX;
                int isY;
                Random generateNumber = new Random();
                isX = generateNumber.Next();
                isY = generateNumber.Next();
                ConsoleKeyInfo keyInfo = Console.ReadKey(); // Takes input
                Console.Clear();
                ConsoleKey key = keyInfo.Key; // Translates input into the corresponding keyboard key.

                if (key == ConsoleKey.A)
                {
                    test.Move(-1, 0); // Runs the class Characters, instance tests Move method with the inputs -1, 0.
                    test.SetPosition(test.GetX(), test.GetY()); // Takes the values from GetX and GetY methods in class Character, instance test and uses those values as the xPos, yPos parameters for the Character method SetPosition.
                    Console.WriteLine("X:" + test.GetX());  // Writes out information from the GetX method in class Character, for the instance test.

                }
                if (key == ConsoleKey.D)
                {
                      
                    test.Move(+1,0); // Runs the class Characters, instance tests Move method with the inputs +1, 0.
                    test.SetPosition(test.GetX(), test.GetY()); // Takes the values from GetX and GetY methods in class Character, instance test and uses those values as the xPos, yPos parameters for the Character method SetPosition.
                    Console.WriteLine("X:" + test.GetX()); // Writes out information from the GetX method in class Character, for the instance test.                       
                }
                if (key == ConsoleKey.W)
                {
                      
                    test.Move(0,+1); // Runs the class Characters, instance tests Move method with the inputs 0, +1.
                    test.SetPosition(test.GetX(), test.GetY()); // Takes the values from GetX and GetY methods in class Character, instance test and uses those values as the xPos, yPos parameters for the Character method SetPosition.
                    Console.WriteLine("Y:" + test.GetY()); // Writes out information from the GetY method in class Character, for the instance test.
                }
                if (key == ConsoleKey.S)
                {
                    test.Move(0,-1); // Runs the class Characters, instance tests Move method with the inputs 0, -1.
                    test.SetPosition(test.GetX(), test.GetY()); // Takes the values from GetX and GetY methods in class Character, instance test and uses those values as the xPos, yPos parameters for the Character method SetPosition.
                    Console.WriteLine("Y:" + test.GetY()); // Writes out information from the GetY method in class Character, for the instance test.
                                   
                }
                if (test.GetX() == isX && test.GetY() == isY)
                {
                    int randomizedItemFound = generateNumber.Next(1, 3);
                    if(randomizedItemFound == 1)
                    {
                        Console.WriteLine("Healthpotion Found!");
                        test.AddToInventory(potion);
                        test.GetItemInfo(randomizedItemFound);

                    }
                    else if(randomizedItemFound == 2)
                    {
                        Console.WriteLine(" Found!");
                        test.AddToInventory();
                        test.GetItemInfo(randomizedItemFound);
                    }
                    else if (randomizedItemFound == 3)
                    {
                        Console.WriteLine(" Found!");
                        test.AddToInventory();
                        test.GetItemInfo(randomizedItemFound);
                    }
                }
                else if (key != ConsoleKey.S && key != ConsoleKey.A && key != ConsoleKey.W && key != ConsoleKey.D)
                {
                    Console.WriteLine("that's not a move key, use WASD.");
                }
                // This else if sends an error message if the player presses other keys than WASD.

                /*
                This while loop will loop when the bool movePlayer is true, which I'll define later. 
                It uses variable ConsoleKeyInfo to read what key a player pressed and the ConsoleKey variable to represent and identify that key.
                The loop contains if statements that runs the Move method of the Character instance test with an increased or decreased value on the xMove or yMove parameter with 1 depending on what key in the key group WASD the player presses. 
                Then it runs the instance test of class Characters GetX respectivly GetY depending on which one was effected in the Move method.
                */


            }
           
        }

           
    }
}

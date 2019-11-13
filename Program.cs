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
            Character test = new Character(); //Creates an instance of the class Character.
                        
            bool movePlayer;

            Item potion = new Healthpotion();

            
            Console.WriteLine(potion.GetInfo()); 
            potion.Use(test);
            Console.WriteLine(test.GetHp()); 

            movePlayer = true;

          
            while (movePlayer == true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                ConsoleKey key = keyInfo.Key;

                if (key == ConsoleKey.A)
                {
                    test.Move(-1, 0);
                    Console.WriteLine(test.GetX());

                }
                if (key == ConsoleKey.D)
                {
                      
                    test.Move(+1,0);
                    Console.WriteLine(test.GetX());                            
                }
                if (key == ConsoleKey.W)
                {
                      
                    test.Move(0,+1);
                    Console.WriteLine(test.GetY());
                }
                if (key == ConsoleKey.S)
                {
                    test.Move(0,-1);
                    Console.WriteLine(test.GetY());
                                   
                }
                else if(key!=ConsoleKey.S&&key!=ConsoleKey.A&&key!=ConsoleKey.W&&key!=ConsoleKey.D)
                {
                    Console.WriteLine("that's not a move key, use WASD.");
                }

                keyInfo = Console.ReadKey();

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

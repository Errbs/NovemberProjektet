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
            Character test = new Character();

            int xMove = 0;
            int yMove = 0;


            
            bool keyPressed;
                      

            keyPressed = true;

          
            while (keyPressed == true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                ConsoleKey key = keyInfo.Key;

                if (key == ConsoleKey.A)
                {
                    test.Move(-1, 0);
                    test.GetX();

                }
                if (key == ConsoleKey.D)
                {
                      
                    test.Move(+1,0);
                    test.GetX();                           
                }
                if (key == ConsoleKey.W)
                {
                      
                    test.Move(0,+1);
                    test.GetY();
                }
                if (key == ConsoleKey.S)
                {
                    test.Move(0,-1);
                    test.GetY();
                                   
                 }
                    else if(key!=ConsoleKey.S&&key!=ConsoleKey.A&&key!=ConsoleKey.W&&key!=ConsoleKey.D)
                    {
                        Console.WriteLine("that's not a move key, use WASD.");
                    }
                    keyInfo = Console.ReadKey();
                //This while is supposed to make the character move, it does not work because the first key press decides if it continus to be positive and negative and the values for x and y gets mixed up


            }
           
        }

           
    }
}

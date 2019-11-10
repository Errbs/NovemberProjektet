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


            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;
            test.Move(key, keyInfo, xMove, yMove);
            test.GetX();
            test.GetY();
            keyInfo = Console.ReadKey();

            /*bool keyPressed = keyInfo != null;

          
            while (keyPressed == true)
            {
                
                    if (key == ConsoleKey.A)
                    {
                        xMove++;
                        test.Move(xMove, yMove);
                        test.GetX();
                        
                       
                    }
                    else if (key == ConsoleKey.D)
                    {
                       xMove--;
                        test.Move(xMove, yMove);
                        test.GetX();
                        
                    }
                    else if (key == ConsoleKey.W)
                    {
                       yMove++;
                        test.Move(xMove, yMove);
                        test.GetY();
                       
                    }
                    else if (key == ConsoleKey.S)
                    {
                        yMove--;
                        test.Move(xMove, yMove);
                        test.GetY();
                                            

                    }
                    else if(key!=ConsoleKey.S||key!=ConsoleKey.A||key!=ConsoleKey.W||key!=ConsoleKey.D)
                    {
                        Console.WriteLine("that's not a move key, use WASD.");
                      
                    }
                    keyInfo = Console.ReadKey();
                //This while is supposed to make the character move, it does not work because the first key press decides if it continus to be positive and negative and the values for x and y gets mixed up


            }
            */
        }

           
    }
}

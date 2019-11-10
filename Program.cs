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
            bool keyPressed;
            bool positive;
            /*test.Move(key, keyInfo, xMove, yMove);
            test.GetX();
            test.GetY();
            keyInfo = Console.ReadKey();
            */

            keyPressed = keyInfo != null;

          
            while (keyPressed == true)
            {
                
                    if (key == ConsoleKey.A)
                    {
                        positive = true;
                        test.Move(xMove, yMove, positive);
                        xMove++;
                        test.GetX();
                        
                       
                    }
                    if (key == ConsoleKey.D)
                    {
                        positive = false;
                        test.Move(xMove, yMove, positive);
                        xMove--;
                        test.GetX();
                        
                    }
                    if (key == ConsoleKey.W)
                    {
                       positive = true;
                       test.Move(xMove, yMove, positive);
                       yMove++;
                        test.GetY();
                       
                    }
                     if (key == ConsoleKey.S)
                     {
                        positive = false;
                        test.Move(xMove, yMove, positive);
                        yMove--;
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

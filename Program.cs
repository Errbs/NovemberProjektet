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
            

            if(key == ConsoleKey.A)
            {
                xMove--;
                test.Move(xMove, yMove);
            }
            else if(key == ConsoleKey.D)
            {
                xMove++;
                test.Move(xMove, yMove);
            }
            else if(key == ConsoleKey.W)
            {
                yMove++;
                test.Move(xMove, yMove);
            }
            else if (key == ConsoleKey.S)
            {
                yMove--;
                test.Move(xMove, yMove);
            }
            else
            {
                Console.WriteLine("wrong key pressed");
            }
            //trying to test the Move method
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovProj
{
    class Healthpotion:Item //This is an Item subclass
    {
        
        public override string GetInfo() //overrides the parentclass Item GetInfo method
        {
            name = "Healthpotion";
            return name + ": increases the HP of the player.";
        }
        //GetInfo method defines the name and returns the name plus a string

        public override void Use(Character target) //overrides the parentclass Item Use method
        {
            target.ModifyHp(10);
        }
        //Use method increases the player HP with 10
    }
}

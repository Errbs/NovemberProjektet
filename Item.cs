using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovProj
{
    class Item
    {
        protected string name;
        public virtual string GetInfo() //Virtual makes the method able to override
        {
            return name;
        }
        public virtual void Use(Character target) //Virtual makes the method able to override
        {

        }

    }
}

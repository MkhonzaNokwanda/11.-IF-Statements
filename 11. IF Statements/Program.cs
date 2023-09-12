using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.IF_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            bool gender = false;

            //! means NOT or NEGATION
            if (gender)
            {
                Console.WriteLine("Female");
            }
            else
            {
                Console.WriteLine("Male");
            }

            bool IsTall=true;

            if (IsTall && gender)
            {
                Console.WriteLine("You are both female & tall");
            }
            else if(!IsTall && gender)
            {
                Console.WriteLine("You are a short female");
            }
            else if(IsTall && !gender)
            {
                Console.WriteLine("You are a tall male");
            }
            else 
            {
                Console.WriteLine("You are a short male");
            }
            //freeze console
            Console.ReadLine();
        }
    }
}

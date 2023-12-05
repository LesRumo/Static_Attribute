using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //its an attribute on the class itself 
            Songs holiday = new Songs("Holiday", "Green Day", 2);
            Songs kashmir = new Songs("Kashmir", "Led Zeppelin", 4);

            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
        }
    }
}

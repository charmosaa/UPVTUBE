using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nationalities;
            void initList()
            {
                nationalities = new List<string>(){
                 "blabla",
                 "bs",
                 "tonteria",
                 "locura",
                 "stoopid"
                };
            }
            initList();
            nationalities.Sort();
            foreach (string nationality in nationalities)
            {
                Console.WriteLine("Hello, " + nationality);
            }
        }
    }
}

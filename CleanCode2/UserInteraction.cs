using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode2
{
    public class UserInteraction
    {
        public static int GetUserInput(string msg = "Enter Input: ")
        {
            Console.WriteLine(msg);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public static void DisplayOutput(int result , string msg)
        {
            Console.WriteLine(msg + " " + result);

        }
    }
}

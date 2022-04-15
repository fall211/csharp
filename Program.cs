using System;   

namespace MyProgram
{
    class MainClass
    {
        static void Main ()
        {
            // variables
            var notdefined = 100; // program will guess what type of variable it is
            int integer = 10;
            string sentence = "string";
            bool yesno = true; // true/false, no caps unlike in python

            Console.WriteLine("set a value for integer " + sentence);
            integer = Convert.ToInt32(Console.ReadLine());
            if (yesno == true){
                Console.WriteLine(Convert.ToString(integer*notdefined));
            }
            
        }
    }
}
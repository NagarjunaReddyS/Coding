using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "nagarjuna";
            char[] charvalue= str.ToCharArray();
            string s = string.Empty;

            for(int i= charvalue.Length - 1; i <= 0; i--)
            {
                s = s + charvalue[i];
            }
            Console.WriteLine(s);
           
        }
    }

   
}

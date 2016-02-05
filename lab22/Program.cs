using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string s = sw.ReadToEnd();
            sw.Close();
            fs.Close();
            string[] array = s.Split(' ');
            int max = -10000;
            int min = 10000;
            for(int i=0; i<array.Length; i++)
            {
                int number = int.Parse(array[i]);
                if(number>max)
                {
                    max = number;
                }   
                if (number<min)
                {
                    min = number;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}

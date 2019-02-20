using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, k, count = 1;
            string buffer;

            string[] str; 
            if (args.Length == 0)
            {
                String s = Console.ReadLine();
                s=s.TrimStart(' ');
                s = s.TrimEnd(' ');
                str = s.Split(new char[] { ' ' });
             
            }

            else
            {
                str = new string[args.Length];
                str = args;
            }

            for (i = 0; i < str.Length; i++)
            {
                for (k = 0; k < str.Length; k++)
                {
                    if (str[i].CompareTo(str[k]) == -1)
                    {
                        buffer = str[i];
                        str[i] = str[k];
                        str[k] = buffer;

                    }
                }
            }


            for (i = 0; i < str.Length - 1; i++)
            {

                if (str[i] == str[i + 1])
                {
                    count++;
                }

               else { Console.WriteLine("{0} {1}", str[i], count); count = 1; }


            }

            Console.WriteLine("{0} {1}", str[str.Length - 1], count);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nine4
{    //дана строка состоящая из 10 слов, напечатать эту же последовательность слов, но в алфавитном порядке
    class Program
    {
       /* static int bubblesort(string[] s)
        {
            int temp;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] > s[j])
                    {
                        temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            return s;
        }*/
        static void Main(string[] args)
        {

            const int n = 3;
            string s1; string s0; char s2;
            char[] alfh = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] s3 = new char[n];
            string[] s = new string[n];
            for(int i=0; i<n;i++)
            {
                Console.WriteLine("vvedite slovo: ");
                s[i] = Console.ReadLine();
                s1 = string.Join(":", s);
               
                s = s1.Split(':');

                s0 = s[i].Substring(0, 1);
                s2 = Convert.ToChar(s0);
                s3[i] = s2;

            }
           /* s1 = string.Join(":",s);
            Console.WriteLine(s1);
            s = s1.Split(':');*/
          //  Console.WriteLine(s.Length);
         
           // char[] s3 = new char[n];
          //  char[] alfh = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
           /* for (int i = 0; i < n; i++)
            {
                s0 = s[i].Substring(0, 1);
                s2 = Convert.ToChar(s0);
                s3[i] = s2;
                Console.WriteLine(" mas " + s3[i]);

            }*/
            /*for (int k=0; k<n; k++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (s3[k] == alfh[j])
                    {
                        Console.WriteLine();
                    }
                }
            }*/
                Console.ReadKey();
        }
    }
}

/*using System;

namespace Test_P
{
    internal class Program
    {
        static void Main()
        {
            int i, j,n=5;
            
 
            for (i = n; i > 0; i--)
            {
                for (j = i; j >0; j--)
                {
                    Console.Write("" + j);
                }
                Console.WriteLine();
            }
        }
    }
}
*/
/*
using System;
namespace TestDemo
{
    class Test
    {
        public static void Main()
        {
            int i, j;
            int n = 6;
            int space = 0;
            for (i = n; i > 0; i--)
            {
                
                
               for(j=0; j<space; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j < i; j++)
                {
                    Console.Write(j);

                }

               Console.Write("\n");
                space += 1;
            }
            Console.ReadLine();
        }
    }
}

// Number Sort 
using System;
namespace  NumberSortTest
{
    class TestSort
    {
        public static void Main()
        {
            int[] num = new int[10];
            int i, j, temp = 0;
            int n;
            Console.WriteLine("Enter N number Size");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
           for(i=0;i<num.Length-1;i++)
            {
                for (j = i +1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }

                }
            }
           for(i=0;i<num.Length;i++)
            {
                Console.Write(" "+num[i]);
            }

        }
    }
}

// String Sort 
using System;
namespace StringSortTest
{
    class StringSort
    {
        public static void Main()
        {
            int temp = 0, i, j;
            Char[] str = new Char[] { 'a', 'a', 'c', 'b', 'a', 'd', 'e', 'b','e'};
            for ( i = 0; i < str.Length - 1; i++)
            {
                for (j = i + 1; j < str.Length; j++)
                {
                    if (str[i] > str[j])
                    {
                        temp = str[i];
                        str[i] = str[j];
                        str[j] = (char)temp;
                    }
                }   
            }
            for ( i = 0; i < str.Length; i++)
            {
                Console.Write(" " + str[i]);
                
            }
         
        }
    }
}

// Duplicate String Count
using System;
namespace DuplicateStringCount
{
    class StringCount
    {
        public static void Main()
        {
            string str = "aaabbcdee";
            for(int i =0;i<str.Length-1;i++)
            {

                int count=1;
                while(str[i]==str[i+1])
                {
                    i++;
                    count++;
                    if(i+1==str.Length)
                    {
                        break;
                    }
                }
                Console.Write(str[i] + "" + count);
            }
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 1;
            int a = 0;
            int b = 0;
            
            int[] realArray = new int[500];
            int[] justarray = new int[500];

            realArray[0] = 1;


            for (int i = 0; i < 20; i++)
            {
                while (realArray[a] != 0)
                {
                    if (realArray[a] == realArray[a + 1])
                    {
                        count++;
                    }
                    else
                    {
                        justarray[b] = realArray[a];       
                        justarray[b + 1] = count;      
                        count = 1;                 
                        b = b + 2;                 
                    }
                    a++;
                }

                Array.Copy(justarray, realArray, justarray.Length);
                a = 0;
                b = 0;

                

                if (i == 19) {
                    Console.Write(i + 1 + "번째 : ");
                    foreach (var arr in realArray)
                {
                    if (arr == 0) break;
                    Console.Write(arr);
                }
                Console.WriteLine();
            }
                }
        }
    }
    }


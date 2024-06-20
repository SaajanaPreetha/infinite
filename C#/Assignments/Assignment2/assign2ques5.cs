using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2ques5
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = new int[100]; 
            int[] arr2 = new int[100];  
            int i, n;  

            Console.WriteLine("\n Copy the elements from one array into another array:\n");

            Console.WriteLine("Enter the number of elements to be stored in the array: ");
            n = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter {0} elements in the array:\n", n);  

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("element - {0} : ", i);  
                arr1[i] = Convert.ToInt32(Console.ReadLine());  
            }

            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];  
            }

            Console.WriteLine("\nThe elements stored in the first array are:\n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}  ", arr1[i]);  
            }

     
            Console.WriteLine("\nThe elements copied into the second array are:\n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}  ", arr2[i]);  
            }

            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}

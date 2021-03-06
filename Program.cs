using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5]; //declaring the size of the array
            arr = new int[] { 20, 25, 55, 24, 12 }; // values given to array
            Console.WriteLine("Display array by using for");
            //Display array by using for loop
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("==============================");


            Console.WriteLine("Display array by using forEach");
            //display array by using forEach
            foreach (int r in arr)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("==============================");
            //sorting of array
            Array.Sort(arr);
            Console.WriteLine("Array after sorting");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("==============================");
            //copy array into another array
            Console.WriteLine("Copying of our array into new array");
            int[] newarr = new int[3];
            Array.Copy(arr, 1, newarr, 0, 3);
            for (int i = 0; i < newarr.Length; i++)
            {
                Console.WriteLine(newarr[i]);
            }

            Console.WriteLine("==============================");
            Console.WriteLine("Reverse of an array");
            //reverse of our array
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("==============================");
            //clear of array
            Console.WriteLine("Clear array by using clear");
            Array.Clear(arr, 1, 3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("==============================");
            Console.WriteLine("String example");

            string[] nameList = new string[] { "Mrunali", "Atul", "Shruti", "Nilam", "Prajakta" };

            Console.WriteLine("Display String array by using for loop");
            //display array by using for loop
            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine(nameList[i]);
            }

            Console.WriteLine("==============================");
            Console.WriteLine("Display String array by using forEach");
            //display array by using forEach
            foreach (string r in nameList)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("==============================");
            //sorting of array
            Array.Sort(nameList);
            Console.WriteLine("String array after sorting");
            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine(nameList[i]);
            }

            Console.WriteLine("==============================");
            //copy array into another array
            Console.WriteLine("Copying of our array into new array");
            string[] newNameList = new string[3];
            Array.Copy(nameList, 1, newNameList, 0, 3);
            for (int i = 0; i < newNameList.Length; i++)
            {
                Console.WriteLine(newNameList[i]);
            }

            Console.WriteLine("==============================");
            Console.WriteLine("Reverse of an array");
            //Reverse of our array
            Array.Reverse(nameList);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(nameList[i]);
            }

            Console.WriteLine("==============================");
            //Clear of array
            Console.WriteLine("Clear array by using clear");
            Array.Clear(nameList, 2, 3);
            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine(nameList[i]);
                Console.ReadLine();
            }

        }
    }
}

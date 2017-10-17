
using System.Collections.Generic;
using System;
using System.Collections;
namespace opdracht_week03
{
    class opdracht_week03
    {
        static void Main(string[] args)
        {   
            int input = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[11];
            List<string> list = new List<string>();
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i <= 10; i++)
            {
                string output = i + " x " + input + " = " + (input*i);
                //Console.WriteLine(output);
                arr[i] = output;
                list.Add(output);
                hashtable[10-i] = output;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            foreach (string key in list)
            {
                System.Console.WriteLine(key);
            }
            foreach (DictionaryEntry entry in hashtable)
            {
                System.Console.WriteLine(entry.Value);
            }
        }
    }
}
using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the length of the fibonacci code:");
            Int64 input = Convert.ToInt64(Console.ReadLine());
            Int64[] arr = new Int64[input];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 0; i < input-2; i++){
                arr[i+2] = arr[i] + arr[i+1];
            }
            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i]);
            }
        }
    }
}

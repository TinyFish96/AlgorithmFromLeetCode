using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "a", "b", "c", "c" };
            Arrange(arr, 0);
            Console.ReadKey();
        }


        /// <summary>
        /// change two elements by their indices
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        private static void swap(string[] arr, int index1, int index2)
        {
            string temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        /// <summary>
        /// recurrance function of Arrangement
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        private static void Arrange(string[] arr,int start)
        {
            //The surplus array contains only one element
            if (start == arr.Length - 1)
            {
                string res = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    res += arr[i];
                }
                Console.WriteLine(res);
            }
            for (int i = start; i < arr.Length; i++)
            {
                //choose the first element
                swap(arr, i, start); 

                //recurrance
                //handle the array from the next element
                Arrange(arr, start + 1);

                //swap back
                swap(arr, i, start);
            }
        }
    }
}
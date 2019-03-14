using System;

namespace NonRecurranceArrangement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 3, 1, 2 };
            ascendSort(arr);
            do
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                }
                Console.WriteLine();
            }
            while (NonRecurranceArrangement(arr));
            
            Console.ReadKey();
        }

        /// <summary>
        /// Sort by ascend
        /// </summary>
        /// <param name="arr"></param>
        private static void ascendSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(arr, j, j + 1);
                    }
                }
            }
        }

        /// <summary>
        /// change two elements by their indices
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        private static void swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        /// <summary>
        /// non-recurrance function of Arrangement
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static bool NonRecurranceArrangement(int[] arr)
        {
            //find swap element from poster to anterior
            int leftIndex = 0, rightIndex = 0;
            bool b = false;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] < arr[i + 1])
                {
                    //arr[i] is the first swap number
                    leftIndex = i;
                    b = true;

                    //get the minimum element that larger than arr[i]
                    int minus = arr[i + 1] - arr[i];
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] > arr[i] && (arr[j] - arr[i]) <= minus)
                        {
                            //refresh the minus distinction
                            minus = arr[j] - arr[i];
                            rightIndex = j;
                        }
                    }
                    break;
                }
            }
            //swap
            swap(arr, leftIndex, rightIndex);

            //upside down the right side of the left swap element
            for (int i = leftIndex + 1; i <= (arr.Length + leftIndex) / 2; i++)
            {
                if (leftIndex == 1)
                {
                    ;
                }
                swap(arr, i, arr.Length + leftIndex - i);
            }
            return b;
        }

    }
}

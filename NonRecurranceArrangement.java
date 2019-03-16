package Test1Package;

public class NonRecurranceArrangement {
	
	static void Main(String[] args)
    {
        int[] arr = new int[] { 4, 3, 1, 2 };
        ascendSort(arr);
        do
        {
            for (int i = 0; i < arr.length; i++)
            {
            	System.out.print(arr[i]);
            }
            System.out.println();
        }
        while (NonRecurrenceArrangement(arr));
    }

    private static void ascendSort(int[] arr)
    {
        for (int i = 0; i < arr.length - 1; i++)
        {
            for (int j = 0; j < arr.length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    swap(arr, j, j + 1);
                }
            }
        }
    }

    private static void swap(int[] arr, int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }

    private static boolean NonRecurrenceArrangement(int[] arr)
    {
        //find swap element from poster to anterior
        int leftIndex = 0, rightIndex = 0;
        boolean b = false;
        for (int i = arr.length - 2; i >= 0; i--)
        {
            if (arr[i] < arr[i + 1])
            {
                //arr[i] is the first swap number
                leftIndex = i;
                b = true;

                //get the minimum element that larger than arr[i]
                int minus = arr[i + 1] - arr[i];
                for (int j = i + 1; j < arr.length; j++)
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
        for (int i = leftIndex + 1; i <= (arr.length + leftIndex) / 2; i++)
        {
            if (leftIndex == 1)
            {
                ;
            }
            swap(arr, i, arr.length + leftIndex - i);
        }
        return b;
    }

}

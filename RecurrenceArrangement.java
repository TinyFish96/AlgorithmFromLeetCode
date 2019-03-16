package Test1Package;

public class RecurrenceArrangement {

	static void Main(String[] args)
    {
        String[] arr = new String[] { "a", "b", "c", "c" };
        Arrange(arr, 0);
    }

    private static void swap(String[] arr, int index1, int index2)
    {
        String temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }



    private static void Arrange(String[] arr,int start)
    {
        //The surplus array contains only one element
        if (start == arr.length - 1)
        {
            String res = "";
            for (int i = 0; i < arr.length; i++)
            {
                res += arr[i];
            }
            System.out.println(res);
        }
        for (int i = start; i < arr.length; i++)
        {
            //choose the first element
            swap(arr, i, start); 

            //Recurrence
            //handle the array from the next element
            Arrange(arr, start + 1);

            //swap back
            swap(arr, i, start);
        }
    }
}

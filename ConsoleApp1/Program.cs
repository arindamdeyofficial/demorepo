int[] arr = new int[] {1,2,2,5,5 };
//int[] arrF = new int[] { };
for (int i=0; i< arr.Length; i++)
{
    bool isDuplicate = false;
    for (int a = 0; a < i; a++)
    {
        isDuplicate = arr[a] == arr[i];        
    }    
    if(!isDuplicate)
    {
        //arrF.Append(arr[i]);
        Console.WriteLine(arr[i]);
    }
}



string[] arr1 = new string[5] {"mik", "230", "suprem", "classs", "sup"};
string[] arr2 = new string[arr1.Length];


void AnaliticArray(string[] arr1, string[] arr2)
{
    int index = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[index] = arr1[i];
        index++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
AnaliticArray(arr1, arr2);
PrintArray(arr2);
string[] InputArray(string[] arr)
{
    Console.WriteLine("Enter elements of array via enter button");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.WriteLine();
    Console.WriteLine("Printed array:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} \t");
    }
}

Console.Clear();
Console.WriteLine("Enter number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
PrintArray(InputArray(array));
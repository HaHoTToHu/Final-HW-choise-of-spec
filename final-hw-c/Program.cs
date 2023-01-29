string[] firstArray = new string[5] { "Moldova", "Roma", "UK", "USA", "Monaco" };
string[] finalArray = new string[firstArray.Length];

void CreateArray(string[] firstArray, string[] finalArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            finalArray[count] = firstArray[i];
            count++;
        }
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

CreateArray(firstArray, finalArray);
ShowArray(finalArray);
string[] CreateArray(int sife)
{
    string[] array = new string[sife];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input array[{i}]: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    string f = String.Empty;
    for (int i = 0; i < array.Length; i++)
        f += $"{array[i]}, ";
    f = f.TrimEnd(new char[] { ',', ' ' });
    Console.Write($"[{f}] -> ");
}

void ShowArray3Symbol(string[] array)
{
    string f = String.Empty;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            f += $"{array[i]}, ";
    f = f.TrimEnd(new char[] { ',', ' ' });
    Console.WriteLine($"[{f}]");
}

Console.Write("Input array size: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(a);
ShowArray(myArray);
ShowArray3Symbol(myArray);


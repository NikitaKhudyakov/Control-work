Console.WriteLine("Введите длинну массива!");
int lengthArray = int.Parse(Console.ReadLine());
int index = 0;
string[] array = CountingSymbol(lengthArray, index);

string[] CountingSymbol(int lengthArray, int index)
{
    string[] array = new string[lengthArray];
    for (int i = 0; i < lengthArray; i++)
    {
        Console.WriteLine("Введите cимвол!");
        string symbol = Console.ReadLine();
        int lengthA = symbol.Length;
        if (lengthA <= 3)
        {
            for (int j = index; j < array.Length; j++)
            {
                array[j] = symbol;
            }
            index++;
        }
    }
    
    Console.WriteLine();
    for (int d = 0; d < index; d++)
    {
        Console.Write($"{array[d]} ");
    }
    return array;
}
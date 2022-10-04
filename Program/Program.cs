Console.Clear();

string[] Array = new string[] {"Russia", "2", "England", "-6"};

string input = String.Empty;
Console.Write("Введите массив (через запятую), или нажмите Enter: ");

input = Console.ReadLine();

if (input == "" || input == null)
{
    Console.WriteLine("Задан массив: ");
    PrintArray(Array);
    Console.WriteLine();

    if (GetNewArray(Array) != null)
    {
        Console.WriteLine($"Новый массив с элементами <= 3 символа: [{String.Join(", ", GetNewArray(Array))}];");
    }

    else
    {
        Console.WriteLine("В заданном массиве нет элементов <= 3 символа");
    }
}

else
{
    char[] separators = new char[] {','};
    Array = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

    Console.WriteLine("Задан массив: ");
    PrintArray(Array);
    Console.WriteLine();

    if (GetNewArray(Array) != null)
    {
        Console.WriteLine($"Новый массив с элементами <= 3 символа: [{String.Join(", ", GetNewArray(Array))}];");
    }

    else
    {
        Console.WriteLine("В заданном массиве нет элементов <= 3 символа");
    }
}


string[] GetNewArray(string[] array)
{
    int index = 0;
    
    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i].Length < 4)
        {
            index++;
        }
    }

    if (index > 0)
    {
        string[] NewArray = new string[index];

        index = 0;

        for (int i = 0; i < array.Length; i++)
        {   
            if(array[i].Length < 4)
            {
                NewArray[index] = array[i];
                index++;
            }
        }

        return NewArray;
    }
    else return null;
    
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]},");
    }
}
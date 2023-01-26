int GetNumber(string message)
{
    int result;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Вы ввели не число.");
    }
    return result;
}

string[] GetArrayFromConsole()
{
    int numberOfElements = GetNumber("Введите размер массива: ");

    string[] array = new string[numberOfElements];

    for (int i = 0; i < numberOfElements; i++)
    {
        Console.Write($"Веедите {i + 1}-й элемент: ");
        array[i] = Console.ReadLine() ?? "";
    }

    return array;
}

string[] SelectStringByLengthToArray (string[] array, int length)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= length)
            count ++;

    string[] newArray = new string[count];
    
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length ; i++)
    {
        if (i == array.Length - 1)
            Console.Write(array[i]);
        else    
            Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}

int CheckUserInput(string message)
{
    int result;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 3)
            break;
        else
            Console.WriteLine("Введите правильное значение.");
    }
    return result;
}

string[] defaultArray = {"hello", "2", "world", ":-)"};
int max_item_length = 3;

int selectUser = CheckUserInput("Введите: 1 - для использования массива по умолчанию. " 
                                +"2 - для ввода массива с клавиатуры.: ");

if (selectUser == 1)
{
    string[] newArray = SelectStringByLengthToArray(defaultArray, max_item_length);
    PrintArray(defaultArray);
    PrintArray(newArray);
}
else
{
    string[] userArray = GetArrayFromConsole();
    string[] newArray = SelectStringByLengthToArray(userArray, max_item_length);
    PrintArray(userArray);
    PrintArray(newArray);
}
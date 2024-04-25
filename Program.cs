

void Array(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

string[] GetNewArrWithThreeAndLessSymb(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArr = new string[count];
    int count2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArr[count2] = array[i];
            count2++;
        }
    }
    return newArr;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

Console.Write("Введите количество элементов: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[num];

Array(arr);
PrintArray(GetNewArrWithThreeAndLessSymb(arr));
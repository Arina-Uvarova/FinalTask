// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] CreateArray(int size)
{
    string[] newArray = new string[size];
    for(int i = 0; i<size; i++)
    {
        Console.WriteLine("Введите элемент массива ");
        newArray[i] = Console.ReadLine(); 
    }
    return newArray;
}

void StringShow(string[] newarray)
{
    for(int i = 0; i < newarray.Length; i++)
    {
        if(newarray[i].Length <= 3)
            Console.Write(newarray[i] + " ");
        
    }
}

Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(n);
Console.WriteLine();
StringShow(myArray);


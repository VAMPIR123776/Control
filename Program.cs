// Написать программу, которая из имеющегося массива строк формируем массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами. 
// Примеры:
// -["hello","2", "world", ":-)"] -> ["2", ":-)"]
// -["1234","1567", "-2", "computer science"] -> ["-2"]
// -["Russia","Denmark", "Kazan"] -> [] 

void FillArray(string[] tempArray, string[] resultArray)
{
    for (int i = 0; i < resultArray.Length; i++)
    {
        for (int j = 0; j < tempArray.Length; j++)
        {
            if (tempArray[j].Length <= 3 && tempArray[j] != string.Empty)
            {
                resultArray[i] = tempArray[j];
                tempArray[j] = string.Empty;
                break;
            }
        }
    }
    PrintArray(resultArray);
}

void PrintArray(string[] resultArray)
{
    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.Write($"{resultArray[i]} ");
    }
}

string[] array = { "hello", "2", "world", ":-)" };
string[] resultArray = new string[array.Length];

FillArray(array, resultArray);
Console.WriteLine();

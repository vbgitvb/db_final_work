/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,

длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,

либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,

лучше обойтись исключительно массивами. 

### Примеры:

["hello","2","world",":-)"] -> ["2",":-)"]

["1234","1567","-2","computer since"] -> ["-2"]

["Russia","Denmark","Kazan"] -> []
*/

int size = 4;
int sizeResultArray = 0;
string[] array = new string[size];
int maxLenght = 3;

if ((sizeResultArray = fillArray(array, maxLenght)) > 0)
{
    string[] resultArray = new string[sizeResultArray];
    copyShortElement(array, resultArray, maxLenght);
    Console.WriteLine($"Результат: [{String.Join(",", resultArray)}]");
}
else Console.WriteLine("Элементы массива из 3-х или менее символов отсутствуют");

/// <summary>
/// Заполняет данными массив, считает количество строк длиной < maxLen символов
/// </summary>
/// <param name="inputArray">массив для заполнения даными</param>
/// <returns>количество строк длиной < maxLen символов</returns>
int fillArray(string[] inputArray, int maxLen)
{
    int count = 0;
    string? tmp = string.Empty;
    if (inputArray.Length != 0)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write($"Введите {i+1} элемент массива: ");
            tmp = Console.ReadLine();
            inputArray[i] += tmp;
            if (inputArray[i].Length <= maxLen) count ++;
        }
    }
return count;
}

/// <summary>
/// Копирует короткие элементы 1 массива в другой
/// </summary>
/// <param name="input">исходный массив с элементами <= 3 символов</param>
/// <param name="result">результирующий массив</param>
void copyShortElement(string[] input, string[] result, int maxLen)
{
   int resultIndex=0; 
   for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= maxLen)   result[resultIndex++] += input[i];
    }
}

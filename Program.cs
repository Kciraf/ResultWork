// Итоговая работа

int NewArrayLength(string[] strArr, int wordSize)
{
    int count = 0;
    for (int i = 0; i < strArr.Length; i++)
    {
        if(strArr[i].Length <= wordSize) count++;
    }
    return count;
}

string[] WordSizeArr(string[] strArr, int wordSize)
{
    int size = 0;
    size = NewArrayLength(strArr, wordSize);
    string[] newArr = new string[size];
    int a = 0;
    if(size > 0 && strArr != null)
    {
        for (int i = 0; i < strArr.Length && a < size; i++)
        {
            if(strArr[i].Length <= wordSize)
            {
                newArr[a] = strArr[i];
                a++;
            }
        }
    }
    else return null;
    return newArr;
}

int wordLength = 3;
Console.WriteLine("Введите элементы массива через пробел: ");
string[] inputArray = Console.ReadLine()!.Split(" ");
string[] resultArray = WordSizeArr(inputArray, wordLength);
if(resultArray == null)
{
    System.Console.WriteLine("В заданном перечне нет слов с длиной менее или равной " + wordLength + ".");
}
else System.Console.WriteLine($"[{String.Join(", ", resultArray)}]");

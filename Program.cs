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
    if(size > 0)
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


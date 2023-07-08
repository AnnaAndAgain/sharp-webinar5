/*
Ищем произведения пар чисел в одномерном массиве 
(первый * последний; второй * предпоследний и т.д.)
Результат в новый массив.

1 2 3 4 5 -> 5 8 3
6 7 3 6 -> 36 21
*/


int[] FillArrayRandom(int tmpLength, int tmpMin, int tmpMax)
{
    int[] tmpArray = new int[tmpLength];
    Random randnum = new Random();

    for (int i = 0; i < tmpArray.Length; i++)
    {
        tmpArray[i] = randnum.Next(tmpMin, tmpMax + 1);
    };

    return tmpArray;
}

void PrintArray(int[] tmpArray)
{
    Console.WriteLine($"[" + string.Join(", ", tmpArray) + "]");
}

int[] MultiplyArray (int[] tmpArray)
{
    int[] resultArray = new int[tmpArray.Length/2+tmpArray.Length%2];
    for (int i = 0; i < tmpArray.Length/2; i++)
    {
        resultArray[i] = tmpArray[i]*tmpArray[tmpArray.Length-i-1];
    }
    if (tmpArray.Length%2==1) 
    {
        resultArray[tmpArray.Length/2] = tmpArray[tmpArray.Length/2];
    }
    return resultArray;
}

int[] array = FillArrayRandom(7, 0, 10);
PrintArray(array);
int[] result = MultiplyArray(array);
PrintArray(result);
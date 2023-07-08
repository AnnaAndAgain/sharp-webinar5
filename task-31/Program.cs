/*
Задаем массив: 12 элементов, от -9 до 9.
Ищем отдельно сумму всех отр и всех положительных чисел.
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

void SumPosNeg(int[] tmpArray, out int tmpSumPos, out int tmpSumNeg)
{
    tmpSumPos = 0;
    tmpSumNeg = 0;
    for (int i = 0; i < tmpArray.Length; i++)
    {
        if (tmpArray[i] < 0)
        {
            tmpSumNeg += tmpArray[i];
        }
        else tmpSumPos += tmpArray[i];
    }
    
}

int[] array = FillArrayRandom(12, -9, 9);
PrintArray(array);
SumPosNeg(array, out int sumPositive, out int sumNegative);

Console.WriteLine($"сумма положительных элементов равна {sumPositive}");
Console.WriteLine($"сумма отрицательных элементов равна {sumNegative}");
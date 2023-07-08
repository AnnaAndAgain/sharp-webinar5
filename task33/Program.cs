/*
Меняем в массиве все эелементы на противоположные 
по знаку (пол на отр, отр на пол)
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

void ChangeSign(int[] tmpArray)
{
    for (int i =0; i < tmpArray.Length; i++)
    {
        tmpArray[i]=-1*tmpArray[i];
    }
}

int[] myArray = FillArrayRandom(10, -100, 100);
PrintArray(myArray);
ChangeSign(myArray);
PrintArray(myArray);
/*
Задаем массив на 123 числа
Ищем число элементов от 10 до 99 вкл.

При сборке все ОК.
Массив формирует и выводит.
Дальше ругается:
[67, 90, 154, 101, 117]
Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
   at Program.<<Main>$>g__CountElementsInRange|0_2(Int32[] tmpArray, Int32 tmpMin, Int32 tmpMax) in D:\учеба\GB\3-C-sharp\webinar-5\tasks\task-35-count-in-range\Program.cs:line 40
   at Program.<Main>$(String[] args) in D:\учеба\GB\3-C-sharp\webinar-5\tasks\task-35-count-in-range\Program.cs:line 47

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

int CountElementsInRange(int[] tmpArray, int tmpMin, int tmpMax)
{
    int count = 0;
    foreach(int i in tmpArray)
    {
        if(i <= tmpMax && i >= tmpMin) count++;
    }
    return count;
}

int[] array = FillArrayRandom(10, 0, 200);
PrintArray(array);
int N = CountElementsInRange(array, 10, 99);
Console.WriteLine(N);
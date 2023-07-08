/*
Задаем массив
Запрашиваем элемент
Сообщаем, есть ли он
*/

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


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

bool FindElem(int[] tmpArray, int tmpElem)
{
    for (int i = 0; i < tmpArray.Length; i++)
    {
        if (tmpArray[i] == tmpElem)
        {
            return true;
        }
    }
    return false;
}

int[] array = FillArrayRandom(5, -10, 10);
PrintArray(array);
int N = ReadInt("Какое число ищем?");
if ( FindElem(array, N)) System.Console.WriteLine("Есть такое число!");
else System.Console.WriteLine("Нет такого числа, увы");
int[] numbers = new int [7];
int n = numbers.Length;

FillArray(numbers);
OutputArrayString(numbers);
CounterEvenNumber(numbers);

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}

void CounterEvenNumber(int[] number)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (number[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine($" -> колличество четных чисел в массиве равно: {count}");
}

void OutputArrayString(int[] arrayString)
{
    string stringArray = "[";

    for (int i = 0; i < arrayString.Length; i++)
    {
        stringArray += $"{arrayString[i]}, ";
    }
    int n = stringArray.Length;
    stringArray = stringArray.Remove(n - 2, 2);
    stringArray += "]";
    Console.Write($"Массив: {stringArray}");
}

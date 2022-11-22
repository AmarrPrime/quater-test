/*Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма,
обойтись массивами. */


Console.WriteLine("Сколько элементов проверяем? ");
int length = int.Parse(Console.ReadLine() ?? "");

string[] strings = new string[length];

string currentString = "";
int count = 0;

for (int i = 0; i < length; i++)
{
    currentString = Console.ReadLine();

    if (currentString.Length <= 3)
    {
        strings[count] = currentString;
        count++;
    }
}

string[] resultStrings = new string[count];

for (int i = 0; i < count; i++)
{
    resultStrings[i] = strings[i];
}


    Console.WriteLine("[{0}]", string.Join(", ", resultStrings));

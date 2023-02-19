// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int Input(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

void TableOfCubes(int N) 
{
    for (int i = 1; i <= N; i++) 
    Console.Write($"{Math.Pow(i, 3)} ");
}

TableOfCubes(Input("Введите число"));
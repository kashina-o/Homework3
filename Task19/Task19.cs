// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Input(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}


int number = Input("Введите пятизначное число");
int reverse = 0;
int n = number;

if(number<=99999 && number>=10000)
{
    while(number > 0)
    {
        reverse = reverse * 10;
        reverse = reverse + number % 10;
        number = number / 10;
    }
    Console.WriteLine(reverse);

    if (reverse == n)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Это не палиндром!");
    }
}
else 
{
    Console.WriteLine("Число не является пятизначным. Пожалуйста, повторите попытку.");
}

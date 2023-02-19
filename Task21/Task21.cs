//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int Input(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Input("Введите координату x1:");
int y1 = Input("Введите координату y1:");  
int z1 = Input("Введите координату z1:"); 

int x2 = Input("Введите координату x2:");
int y2 = Input("Введите координату y2:");  
int z2 = Input("Введите координату z2:");

int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;

Console.WriteLine($"Длина отрезка = {Math.Round(Math.Sqrt(x * x + y * y + z * z), 2)}");

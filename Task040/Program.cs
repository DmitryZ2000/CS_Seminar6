void CheckTrangle(int a, int b, int c)
{
if (a + b > c && a + c > b && b + c > a)
     Console.WriteLine("Такой треугольник ДА существует");
else Console.WriteLine("Такой треугольник НЕ существует");
}

CheckTrangle(3, 4, 15);

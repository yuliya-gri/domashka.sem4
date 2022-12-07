
//напишите программу, которая на вход принимает число
//и выдает сумму цифр в числе

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int SummNum(int N)
{
  int sum = 0;
    while (N > 0)
    {
        sum = sum + N %10;
        N = N / 10;
    }
    return sum;
}     
    
Console.WriteLine($"Сумма всех цифр в числе {N} равна {SummNum(N)} ");
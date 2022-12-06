
//напишите программу, которая на вход принимает число
//и выдает сумму цифр в числе

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int SummNum(int N)
{   int num = 0;
    for(int i = 1; i <= N; i++ ) num += i;
    return num;
}

Console.WriteLine($"Сумма всех цифр в числе {N} равна {SummNum(N)} ");
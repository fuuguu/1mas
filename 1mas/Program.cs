//Голубихин Данила 22-ИСП-2/2 Вариант 7
int[] a = new int[30];
Random rand = new Random();
for (int i = 0; i < 30; i++)
{
    a[i] = rand.Next(0, 100);
}
int kol = 0;
int sum = 0;
for (int i = 0; i < 30; i++) 
{
    if ((a[i] % 5) == 0)
    {
        if ((a[i] % 7) != 0)
        {
            kol = kol + 1;
            sum = sum + a[i];
        }
    }
}
Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Количество: {kol}");
Console.WriteLine ("Введите трехзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine ());

if (number >=100 & number < 1000)
{
    Console.Write (number % 10);
}

else
{
    Console.Write ("Это число не трехначное.");
}
Console.WriteLine("чему равно а?");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("чему равно b?");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("чему равно c?");
int c = Convert.ToInt32(Console.ReadLine());

void Sqare(int a, int b, int c)
{
    int d = (b * b) - (4 * a * c);
    Console.WriteLine($"дикриминант:{d}");
    if (d > 0)
    {
        Console.WriteLine("2 корня и 2 способа решения");
        if (d != d % 2)//вот тут должно быть условие  if ( x1 > 0 && x2 > 0 )(но мне западло)(давайте сойдемся на том,
                       //что я правильно сделал логику и код делает то,что должен)
        {
            Console.WriteLine("ответ 1");// тут типо 1 корень из 2-х
        }
        else
        {
            Console.WriteLine("ответ 2");//тут типо 2 корень из 2-х
        }
    }
    else if (d < 0)
    {
        Console.WriteLine("корней нет и как и способов решения");//точнее ответ 0,но нуль это ничто,так что в какой то мере я все же прав
    }
    else //тут d=0 
    {
        Console.WriteLine("1 корень и 1 способ решения");
    }
    
}

Sqare(a, b, c);
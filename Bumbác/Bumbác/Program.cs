//zadání
/*
Napište program, který vypíše prvních 100 přirozených čísel od jedničky do stovky, ovšem tak,
1) že místo čísel dělitelných třemi vypíše "bum";
2) že místo čísel dělitelných pěti vypíše "bác"; a
3) že místo čísel dělitelných třemi i pěti vypíše "bumbác"
Výsledek tedy bude vypadat takto:
1, 2, bum, 4, bác, bum, 7, 8, ..., 14, bumbác, 16, ..., 98, bum, bác
Jednotlivá čísla oddělte čárkou nebo koncem řádku
*/

//oddělené čárkou 
/*string[] numbers = new string[100];

for (int i=1; i<=100; i++)
{         
    if(i % 3 == 0 && i % 5 == 0)
    {
        numbers[i - 1] = "Bumbác";
    }
    else if(i % 3 == 0)
    {
        numbers[i - 1] = "Bum";
    }
    else if(i % 5 == 0)
    {
        numbers[i - 1] = "Bác";
    }
    else
    {
        numbers[i - 1] = i.ToString();
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    if(i != numbers.Length - 1)
    {
        Console.Write(numbers[i] + ", ");
    }
    else
    {
        Console.Write(numbers[i]);
    }

}*/

//oddělené koncem řádku

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("Bumbác");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Bum");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Bác");
    }
    else
    {
        Console.WriteLine(i);
    }
}

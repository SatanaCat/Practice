Console.WriteLine("Задание 1");
Console.WriteLine(Opposite_number(4));
Console.WriteLine(Opposite_number(-25));
Console.WriteLine();
Console.WriteLine("Задание 2");
Console.WriteLine(Uppercase_letter("иванов иван иванович"));
Console.WriteLine(Uppercase_letter("петров дмитрий владимирович"));
Console.WriteLine();
Console.WriteLine("Задание 3");
Console.WriteLine(Rock_Paper_Scissors("камень","ножницы"));
Console.WriteLine(Rock_Paper_Scissors("бумага", "ножницы"));
Console.WriteLine(Rock_Paper_Scissors("ножницы", "ножницы"));
Console.WriteLine();
Console.WriteLine("Задание 4");
Console.WriteLine(Rabbits(1,5));
Console.WriteLine(Rabbits(2,5));
int Opposite_number(int num)
{
    return num * -1;
}
string Uppercase_letter(string name)
{
    string[] s = name.Split(' ');

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length > 1)
            s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1, s[i].Length - 1).ToLower();
        else s[i] = s[i].ToUpper();
    }
    return string.Join(" ", s);
}
string Rock_Paper_Scissors(string playerOne, string playerTwo)
{
    switch(playerOne)
    {
        case "камень":
            if (playerTwo == "камень") return "Ничья";
            if (playerTwo == "бумагу") return "Выйграл второй игрок";
            if (playerTwo == "ножницы") return "Выйграл первый игрок";
            break;
        case "ножницы":
            if (playerTwo == "камень") return "Выйграл второй игрок";
            if (playerTwo == "бумагу") return "Выйграл первый игрок";
            if (playerTwo == "ножницы") return "Ничья";
            break;
        case "бумага":
            if (playerTwo == "камень") return "Выйграл первый игрок";
            if (playerTwo == "бумагу") return "Ничья";
            if (playerTwo == "ножницы") return "Выйграл второй игрок";
            break;
    }
    return "";
}
int Rabbits(int start, int finish)
{
    int a = 0;
    for (int i = start;;)
    {
        if (i + 3 <= finish)
        {
            i = i + 3;
            a++;
        }
        else
        {
            if (i + 1 <= finish)
            {
                i++;
                a++;
            }
        }
        if ( i == finish)
        {
            break;
        }
    }
    return a;
}
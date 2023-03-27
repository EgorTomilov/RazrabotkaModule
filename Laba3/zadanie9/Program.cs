// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите текст");
string text;
string text2 = "";

text = Console.ReadLine();



for (int i = 0; i < text.Length; i++)
{
    if (text[i] == 'а')
    {
        text2 += 'А';
        continue;
    }
    text2 += (text[i]);
}

Console.WriteLine("Исправлено:" + text2);

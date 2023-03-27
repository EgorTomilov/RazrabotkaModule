// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите текст");
string text = Console.ReadLine();
string[] words = text.Split(new char[] { ',', ' ' });

string max = ""; int maxIndex = 0;
string min = "0123456789"; int minIndex = 0;
int i = 0;

foreach (string word in words)
{
    if (word.Length > max.Length)
    {
        max = word;
        maxIndex = i;
    }

    if (word.Length < min.Length)
    {
        min = word;
        minIndex = i;
    }

    i++;
}

Console.WriteLine("Самое коротокое слово: {0}, позиция = {1}", min, minIndex + 1);
Console.WriteLine("Самое длинное слово: {0}, позиция = {1}", max, maxIndex + 1);
Console.ReadKey(true);

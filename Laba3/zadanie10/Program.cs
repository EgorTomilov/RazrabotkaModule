// See https://aka.ms/new-console-template for more information
string text = "Ну, вот типа да и нет и вообще да, хотя да нет или не да?";

string firstLetter = text[0].ToString().ToLower();

string lastLetter = text[text.Length - 2].ToString().ToLower();

int countFirstLetter = 1;

int countLastLetter = 1;

for (int i = 1; i < text.Length - 2; i++)
{
    if (text[i].ToString().ToLower() == firstLetter)
    {
        countFirstLetter++;
    }
    if (text[i].ToString().ToLower() == lastLetter)
    {
        countLastLetter++;
    }
}
Console.WriteLine($"Буква {firstLetter} встречается {countFirstLetter} раз");

Console.WriteLine($"Буква {lastLetter} встречается {countLastLetter} раз");
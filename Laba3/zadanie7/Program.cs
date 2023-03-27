// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите текст");
string text = Console.ReadLine();
string[] str = text.Split(new Char[] { ' ', ',', '.', ';', ':', '!', '?', }, StringSplitOptions.RemoveEmptyEntries);
int minsimv = 0, maxsimv = 0;
for (int i = 0; i < str.Length; i++) 
{ 
if (str[i].Length > maxsimv) 
    { 
        maxsimv = str[i].Length;
        minsimv = i;

}
}

Console.WriteLine("Самое длинное слово: {0}", str[minsimv]);
Console.ReadLine();
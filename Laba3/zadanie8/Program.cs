// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите текст");
string text = Console.ReadLine();

int kollicestvoBykv = 0;

if (text.Length > 2)
    for (int i = 1; i < text.Length; i += 2)
        if (text[i] == 'у')
            kollicestvoBykv ++;
Console.WriteLine(kollicestvoBykv );
Console.ReadKey();

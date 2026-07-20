//Попросить пользователя ввести текст
//Проверить ввод
//Если пользователь ввел пустую строку или только пробелы, вывести ошыбку
Console.WriteLine("Напишите слова");
string text = Console.ReadLine();
var count = new Dictionary<string, int>();
if (string.IsNullOrWhiteSpace(text))
{
    Console.WriteLine("Текст не должен быть пустым");
}
else
{

    string[] words = text.Split(' ');

    foreach (string word in words)
    {
        string cleanWord = word.Trim().ToLower();
        if (string.IsNullOrWhiteSpace(cleanWord))
        {
            continue;
        }
        if (count.ContainsKey(cleanWord))
        {
            count[cleanWord]++;
        }
        else
        {
            count[cleanWord] = 1;
        }
    }
    Console.WriteLine("Результат:");
    foreach (var pair in count)
    {
        Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
}
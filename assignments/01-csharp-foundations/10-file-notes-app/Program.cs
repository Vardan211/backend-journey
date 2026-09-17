var path = "notes.txt";

while (true)
{
    Console.WriteLine("1. Добавить заметку");
    Console.WriteLine("2. Показать все заметки");
    Console.WriteLine("3. Найти заметку по слову");
    Console.WriteLine("0. Выйти");
    Console.Write("Выберите команду: ");

    var command = Console.ReadLine();

    switch (command)
    {
        case "1":
            Console.Write("Введите заметку: ");
            var note = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(note))
            {
                Console.WriteLine("Заметка не может быть пустой.");
                return;
            }
            File.AppendAllText(path, note + Environment.NewLine);
            Console.WriteLine("Заметка сохранена.");
            break;
        case "2":
            if (!File.Exists(path))
            {
                Console.WriteLine("Заметок пока нет.");
                return;
            }

            var lines = File.ReadAllLines(path);

            if (lines.Length == 0)
            {
                Console.WriteLine("Заметок пока нет.");
                return;
            }
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            break;

        case "3":
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine("Заметок пока нет.");
                    break;
                }

                Console.Write("Введите слово для поиска: ");
                var word = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(word))
                {
                    Console.WriteLine("Слово для поиска не может быть пустым.");
                    break;
                }

                var liness = File.ReadAllLines(path);
                var found = false;

                foreach (var line in liness)
                {
                    if (line.Contains(word))
                    {
                        Console.WriteLine(line);
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Ничего не найдено.");
                }

                break;
            }

        case "0":
            Console.WriteLine("Пока!");
            return;

        default:
            Console.WriteLine("Неизвестная команда.");
            break;
    }
}
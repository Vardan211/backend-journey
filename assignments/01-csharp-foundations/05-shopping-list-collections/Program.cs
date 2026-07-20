using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

var listProducts = new List<string>();
while (true)
{
    Console.WriteLine("1. Добавить покупку\r\n2. Показать список\r\n3. Найти покупку\r\n4. Удалить покупку\r\n5. Очистить список\r\n0. Выйти");
    string answer = Console.ReadLine();
    switch (answer)
    {
        case "1":
            Console.WriteLine("Напиши имя товара");
            string product = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(product))
            {
                Console.WriteLine("Поле не должно быть пустым");
            }
            else
            {
                listProducts.Add(product.Trim());
                Console.WriteLine("Товар добавлен");
            }
            break;


        case "2":
            if (listProducts.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
            Console.WriteLine("Список продуктов");
            for (int i = 0; i < listProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listProducts[i]}");
            }

            break;

        case "3":
            Console.WriteLine("Напишите имя товара который вам нужен");
            string search = Console.ReadLine();
            if(listProducts.Contains(search, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Результат:\r\n" + search);
            }
            else
            {
                Console.WriteLine("Такого товара нет");
            }
            break;

        case "4":
            Console.WriteLine("Напишите число товара который нужно удалить");
            search = Console.ReadLine();
            int max = listProducts.Count;
            bool isNumber = int.TryParse(search, out int number);
            if (isNumber == false)
            {
                Console.WriteLine("Это не число");
            }
            else
            {
                if (number < 1 || number > max)
                {
                    Console.WriteLine("Такого номера нет");
                }
                else
                {

                    int index = number - 1;
                    listProducts.RemoveAt(index);
                    Console.WriteLine("Товар успешно удален");

                }

            }
            break;

        case "5":
            if (listProducts.Count == 0)
            {
                Console.WriteLine("Корзина уже пуста");
            }
            else
            {
                listProducts.Clear();
                Console.WriteLine("Корзина очищена");

            }
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Такой команды нету");
            break;
    }


}
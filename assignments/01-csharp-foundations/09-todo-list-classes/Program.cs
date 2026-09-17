//создать меню с выбором 1.создать задачу 2.посмотреть невыполнение задание 3.удалиьт задание 4.выйти из задания
//сделать проверку что бы пустой текст выдал ошыбку
//сделать проверку что бы в меню если нет такого действия выдать ошибку
using _09_todo_list_classes;

var todoItems = new List<TodoItem>();
while (true)
{
    Console.WriteLine("1.добавть задачу");
    Console.WriteLine("2.Показать все задачи");
    Console.WriteLine("3.Показать все не выполненые задачи");
    Console.WriteLine("4.Отметить задачу выполненной");
    Console.WriteLine("5.Показать все выполненые задачи");
    Console.WriteLine("6.удалит задачу");
    Console.WriteLine("0.Выход");
    var answer = Console.ReadLine();
    switch (answer)
    {
        case "1":
            Console.WriteLine("Напишите имя задачи");
            var title = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Поле не должно быть пустым");
            }
            else
            {
                var todoItem = new TodoItem(title);
                todoItems.Add(todoItem);
                Console.WriteLine("Задача добавлена");
            }
            
            break;
        case "2":
            if (todoItems.Count == 0)
            {
                Console.WriteLine("Нету заданий");
                break;
            }
            int quantity = 1;
            foreach (var item in todoItems)
            {
                if (item.IsDone == false)
                {
                    Console.WriteLine($"{quantity}. {item.Title} - Не выполнено");
                    quantity++;
                }
                else
                {
                    Console.WriteLine($"{quantity}. {item.Title} - выполнено");
                    quantity++;
                }
            }
            break;
        case "3":
            if (todoItems.Count == 0)
            {
                Console.WriteLine("Нету заданий");
                break;
            }
            int quantityUnfulfilledItem = 1;
            foreach (var item in todoItems)
            {
                if (item.IsDone == false)
                {
                    Console.WriteLine($"{quantityUnfulfilledItem}. {item.Title} - Не выполнено");
                    quantityUnfulfilledItem++;
                }

            }
            if (quantityUnfulfilledItem == 1)
            {
                Console.WriteLine("Невыполненных задач нет");
            }
            break;
        case "4":
            var unfinishedTasks = new List<TodoItem>();
            if (todoItems.Count == 0)
            {
                Console.WriteLine("Нету заданий");
                break;
            }
            int quantitys = 1;
            foreach (var item in todoItems)
            {
                if (item.IsDone == false)
                {
                    Console.WriteLine($"{quantitys}. {item.Title} - Не выполнено");
                    quantitys++;
                    unfinishedTasks.Add(item);
                }
            }
            if (unfinishedTasks.Count == 0)
            {
                Console.WriteLine("Невыполненых заданий нет");
                break;
            }
            Console.WriteLine("Напишите номер задания");
            var option = Console.ReadLine();
            var shownCount = quantitys - 1;
            bool isNumber = int.TryParse(option, out int number);
            if (isNumber == false)
            {
                Console.WriteLine("Это не число");
            }
            else
            {
                if (number < 1 || number > shownCount)
                {
                    Console.WriteLine("Такого номера нет");
                }
                else
                {
                    var index = number - 1;
                    var selected = unfinishedTasks[index];
                    selected.MarkTask();
                    Console.WriteLine("Задача отмечена выполненной");
                }
            }
            break;
        case "5":
            if (todoItems.Count == 0)
            {
                Console.WriteLine("Нету заданий");
                break;
            }
            int quantityCompletedItems = 1;
            foreach (var item in todoItems)
            {
                if (item.IsDone == true)
                {
                    Console.WriteLine($"{quantityCompletedItems}. {item.Title} - выполнено");
                    quantityCompletedItems++;
                }

            }
            if (quantityCompletedItems == 1)
            {
                Console.WriteLine("Выполненных задач нет");
            }
            break;
        case "6":
            if (todoItems.Count == 0)
            {
                Console.WriteLine("Нету заданий");
                break;
            }
            int quantit = 1;
            foreach (var item in todoItems)
            {
                if (item.IsDone == false)
                {
                    Console.WriteLine($"{quantit}. {item.Title} - Не выполнено");
                    quantit++;
                }
                else
                {
                    Console.WriteLine($"{quantit}. {item.Title} - выполнено");
                    quantit++;
                }

            }
            Console.WriteLine("Выберите какую задачу удалить");
            var reply = Console.ReadLine();
            int max = todoItems.Count;
            bool isNumerals = int.TryParse(reply, out int numeral);
            if (isNumerals == false)
            {
                Console.WriteLine("Это не число");
            }
            else
            {
                if (numeral < 1 || numeral > max)
                {
                    Console.WriteLine("Такого номера нет");
                }
                else
                {
                    var index = numeral - 1;
                    var chosen = todoItems[index];
                    todoItems.Remove(chosen);
                    Console.WriteLine("Задание успешно удалено");
                }
                
            }
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Такой команды нет");
            break;
    }

}
using _11_foundation_capstone_study_tracker;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
string pattern = @"^Задача:\s+(.+?)\s+Предмет:\s+(.+?)\s+Состояние:\s+(true|false)$";
List<StudyTask> listTasks = new List<StudyTask>();
while (true)
{
    Console.WriteLine("1. Добавить задачу");
    Console.WriteLine("2. Показать все задачи");
    Console.WriteLine("3. Показать задачи по предмету");
    Console.WriteLine("4. Отметить задачу выполненной");
    Console.WriteLine("5. Сохранить задачи в файл");
    Console.WriteLine("6. Загрузить задачи из файла");
    Console.WriteLine("7. Удалить задачу");
    Console.WriteLine("0.Выйти");
    string answer = Console.ReadLine();
    switch (answer)
    {
        case "1":
            Console.Write("Введите название задачи: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Название задачи не может быть пустой.");
                return;
            }

            Console.Write("Введите название Предмета: ");
            string subject = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(subject))
            {
                Console.WriteLine("Название предмета не может быть пустой.");
                return;
            }
            StudyTask newTask = new StudyTask(name, subject);
            listTasks.Add(newTask);

            break;
        case "2":
            if (listTasks.Count == 0)
            {
                Console.WriteLine("Нету задач");
                break;
            }
            int number = 1;
            foreach (StudyTask taskItem in listTasks)
            {
                Console.WriteLine($"{number}.Задача: {taskItem.Name} Предмет: {taskItem.Subjeckt} Состояние {taskItem.IsDone}");
                number++;
            }

            break;
        case "3":
            Console.WriteLine("Напишите по какому предмету");
            string search = Console.ReadLine();
            bool empty = true;
            foreach (StudyTask taskItem in listTasks)
            {
                if (search == taskItem.Subjeckt)
                {
                    Console.WriteLine($"Задача: {taskItem.Name} Предмет: {taskItem.Subjeckt} Состояние {taskItem.IsDone}");
                    empty = false;
                }

            }
            if (empty == true)
            {
                Console.WriteLine("Пусто");
                break;
            }
            break;
        case "4":
            if (listTasks.Count == 0)
            {
                Console.WriteLine("Нету задач");
                break;
            }
            number = 1;
            foreach (StudyTask taskItem in listTasks)
            {
                Console.WriteLine($"{number}.Задача: {taskItem.Name} Предмет: {taskItem.Subjeckt} Состояние {taskItem.IsDone}");
                number++;
            }
            Console.WriteLine($"Выберите какую задачу отметить");
            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber >= 1 && taskNumber <= listTasks.Count)
                {
                    int index = taskNumber - 1;
                    listTasks[index].IsDone = true;
                }
                else
                {
                    Console.WriteLine("Задачи с таким номером нет.");
                }

            }
            else
            {
                Console.WriteLine("Нужно ввести целое число.");
            }
            break;
        case "5":
            if (listTasks.Count == 0)
            {
                Console.WriteLine("Нету задач");
                break;
            }
            string path = "dadada.txt";
            List<string> lines = new List<string>();
            foreach (StudyTask taskItem in listTasks)
            {
                string formatet = "Задача: " + taskItem.Name + " Предмет: " + taskItem.Subjeckt + " Состояние: " + taskItem.IsDone;
                lines.Add(formatet);
            }
            File.WriteAllLines(path, lines);
            Console.WriteLine(Directory.GetCurrentDirectory());
            break;
        case "6":
            int dublicate = 0;
            List<StudyTask> temporaryTasks = new List<StudyTask>();
            List<string> errors = new List<string>();
            string information = Console.ReadLine();
            if (File.Exists(information) == false)
            {
                Console.WriteLine("Такой файла нету");
                break;
            }
            else
            {
                string[] oldText = File.ReadAllLines(information);
                for (int i = 0; i < oldText.Length; i++)
                {
                    
                    Match match = Regex.Match(oldText[i], pattern);
                    string[] kov = oldText[i].Split(' ');

                    if (match.Success)
                    {
                        if (bool.TryParse(kov[5], out bool isDone))
                        {
                            if (errors.Count == 0)
                            {
                                StudyTask newTaskFromFile = new StudyTask(kov[1], kov[3], isDone);
                                temporaryTasks.Add(newTaskFromFile);
                            }

                        }
                        else
                        {
                            Console.WriteLine($"Неправелный формат должен быть fals или true на строке {i + 1}");
                            errors.Add(kov[5]);
                        }


                    }
                    else
                    {
                        Console.WriteLine($"Неправелный формат на строке {i + 1}");
                        errors.Add(kov[0]);
                    }


                }
                if (errors.Count == 0)
                {

                    foreach (StudyTask loadedTask in temporaryTasks)
                    {
                        bool exists = listTasks.Any(task => loadedTask.Name == task.Name && loadedTask.Subjeckt == task.Subjeckt);
                        if (exists == false)
                        {
                            listTasks.Add(loadedTask);
                        }
                        else
                        {
                            dublicate++;
                        }
                    }
                }
                Console.WriteLine($"Получилось столько дубликатов {dublicate}");
            }

            break;
        case "7":
            if (listTasks.Count == 0)
            {
                Console.WriteLine("Нету задач");
                break;
            }
            number = 1;
            foreach (StudyTask taskItem in listTasks)
            {
                Console.WriteLine($"{number}.Задача: {taskItem.Name} Предмет: {taskItem.Subjeckt} Состояние {taskItem.IsDone}");
                number++;
            }
            Console.WriteLine($"Выберите какую задачу отметить");
            if (int.TryParse(Console.ReadLine(), out int taskNumberName))
            {
                if (taskNumberName >= 1 && taskNumberName <= listTasks.Count)
                {
                    int index = taskNumberName - 1;
                    listTasks.RemoveAt(index);
                    Console.WriteLine("Товар успешно удален");
                }
                else
                {
                    Console.WriteLine("Задачи с таким номером нет.");
                }

            }

            break;
        case "0":


            break;
        default:
            break;
    }


}
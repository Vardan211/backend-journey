//создать пустой список оценок
//попросить пользователя ввести оценку
//прочитать строку
//если строка пустая:закончить ввод
//если строка не число:показать ошибку
//если число меньше 1 или больше 5: показать ошибку
//добавить оценку в список
//если список пустой:сказать, что оценок нет
//вывести количество
//вывести среднюю
//вывести минимум
//вывести максимум
//вывести количество пятерок

using System.Numerics;

var assessments = new List<int>();
while (true)
{
    Console.WriteLine("1. Добавить оценку 1-5\r\n2. Вывести оценки");
    string answer = Console.ReadLine();
    switch (answer)
    {
        case "1":

            Console.WriteLine("Напишите оценку 1-5");
            string gradeText = Console.ReadLine();
            if (!IsValidGradeInput(gradeText))
            {
                continue;
            }
            int grade = int.Parse(gradeText);
            assessments.Add(grade);
            Console.WriteLine("оценка добавлена");
            break;

        case "2":

            if (assessments.Count == 0)
            {
                Console.WriteLine("Список оценок пуст");
            }

            else
            {
                Console.WriteLine("Оценки ");
                Console.WriteLine("Средная оценка: " + CalculateAverageGrade(assessments));
                Console.WriteLine("Количества пятерока " + CalculateFivesCount(assessments));
                Console.WriteLine("Минимальная оценка " + CalculateMinimumGrade(assessments));
                Console.WriteLine("Максимальная оценка " + CalculateMaxGrade(assessments));
            }
            break;
        default:
            Console.WriteLine("Такого варианта нету");
                break;
    
    }
}
bool IsValidGradeInput(string inputText)
{
    if (string.IsNullOrWhiteSpace(inputText))
    {
        Console.WriteLine("Поле не должно быть пустым");
        return false;
    }
    if (!int.TryParse(inputText, out int grade))
    {
        Console.WriteLine("Нужно ввести число");
        return false;
    }
    if (grade < 1 || grade > 5)
    {
        Console.WriteLine("Оценка должна быть от 1 до 5");
        return false;
    }
    return true;

}
double CalculateAverageGrade(List<int> grades)
{
    double average = grades.Average();
    return average;
}

int CalculateFivesCount(List<int> grades)
{
    int max = 0;
    foreach(int grade in grades) 
    {
        if(grade == 5)
        {
            max++;
        }
    }
    return max;
}

int CalculateMinimumGrade(List<int> grades)
{
    int min = grades.Min();
    return min;
}

int CalculateMaxGrade(List<int> grades)
{
    int max = grades.Max();
    return max;
}



//программа загадывает число от `1` до `100` int думаю используем
//пользователя угадать число
//неверный ввод вроде  обрабатывается как ошибка
//если попытка меньше ответа, программа пишет `Больше`;
//Надо что бы пользователь попытался еще раз
//если попытка больше ответа, программа пишет `Меньше`
Random random = new Random();
int secretNumber = random.Next(1,101);
Console.WriteLine("Программа загадала число, угадайте какое");
int attemptCount = 0;
int number = GetAnswer();
while (true)
    {
    if (number < secretNumber)
    {
    
    Console.WriteLine("Неправильно, число больше");
    
    
   
    }
    if (number > secretNumber)
    {
    
    Console.WriteLine("Неправильно, число меньше");
    
    
    
    }
    if (number == secretNumber)
    {
        Console.WriteLine("Правильно");
        attemptCount++;
        Console.WriteLine($"Количество попыток - {attemptCount}");
        Console.ReadLine();
        return;
    }
    number = GetAnswer();
    attemptCount++;
}


//получает ответ от пользователя
//проверка ответа пользователя
//выдать ошибку если проверка не прошла, надо что бы пользователь попытался снова
//возрощает ответ
int GetAnswer()
{
    string answer = Console.ReadLine();
    bool isNumber = int.TryParse(answer, out int number);
    while (isNumber == false)
    {
        Console.WriteLine("Надо написать число");
        answer = Console.ReadLine();
        isNumber = int.TryParse(answer, out int numberSecond);
        number = numberSecond;
        attemptCount++;

    }

    return number;
}


//1.1 надо чтобы калькулятор писал "напишите число"
//1.2 читаем ввод пользователя
//1.3 делаем проверку числа через tryprase
//1.4 если проверкак не прошла программа должна написать ошибка
//1.5 программа пишет напишите + - * / 
//1.6 проверка ввода пользователя 
//1.7 надо чтобы калькулятор писал "напишите число"
//1.8 читаем ввод пользователя
//1.9 делаем проверку числа через tryprase
//2.0 что бы программа посчитала 
//2.1 отправить ответ пользователю 

Console.WriteLine("напишите число");
string numberText = Console.ReadLine();
bool isNumber = double.TryParse(numberText, out double numberFirst);
if (isNumber == false)
{
   
    Console.WriteLine("Надо написать число");
    Console.ReadLine();
    return;


}
Console.WriteLine("Напишите + - * /");
string operationText = Console.ReadLine();
if (operationText == "+" || operationText  == "-"|| operationText == "*" || operationText  == "/")
    {

    Console.WriteLine("напишите второе число");
    string numberTextSecond = Console.ReadLine();
    bool isNumberSecond = double.TryParse(numberTextSecond, out double numberSecond);
    if (isNumberSecond == false)
    {

        Console.WriteLine("Надо написать число");
        Console.ReadLine();
        return;


    }
    double result;
    switch (operationText)
    {
        case "+":
            result = numberFirst + numberSecond;
            Console.WriteLine("Результат " + result);
            Console.ReadLine();
            return;
        case "-":
            result = numberFirst - numberSecond;
            Console.WriteLine("Результат " + result);
            Console.ReadLine();
            return;
        case "*":
            result = numberFirst * numberSecond;
            Console.WriteLine("Результат " + result);
            Console.ReadLine();
            return;
        case "/":
            if (numberSecond == 0)
            {
                Console.WriteLine("Нельзя делить на 0");
                Console.ReadLine();
                return;

            }
            result = numberFirst / numberSecond;
            Console.WriteLine("Результат " + result);
            Console.ReadLine();
            return;
        
    }

}
else 
{
    Console.WriteLine("Неправильная операция");
    Console.ReadLine();
    return;

}
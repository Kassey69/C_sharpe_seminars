/*Задание 2. Функция принимает 3-х значное число. Удалить 2 цифру числа
521 и убрать 2 -- DeleteDigit
*/
    int function(int num)
    {
      int n1 = (num / 100)*10;
      int n2 = num % 10;  
      return n1+n2;  
    }
    int number = new Random().Next(100, 999);
    Console.WriteLine(" Current number " + number + " убираем 2 число и получаем " + function(number) + " " );
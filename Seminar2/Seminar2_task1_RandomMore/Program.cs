/* Задание 1. Вводим случайное число от 10 до 89. 
И надо вывести большую цифру этого числа. 
Например число 48. Нужно вывести 8, вторую чифру числа.
Написать задачу в виде фУНКЦИИ
*/
int FindMaxNum(int num)    // этого как бы нет, это шаблон алгоритма по котрому
                          //будет решаться задача, когда будет вызвана чугкция
                        //ее можно записать и ниже и выше и где угодно. 
                        //она находится на другой ветке вообще
{
    int n1 = num % 10;
    int n2 = num / 10;

    if (n1 > n2)
    {
        return n1;
    }
    else
    {
        return n2;
    }
}
    int number = new Random().Next(10, 99);
    Console.WriteLine(" Current number " + number + " max part is " + FindMaxNum(number));



// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
// aa
// ab
// ac
// ba
// bb
// bc
// ca
// cb
// cc
//3
//aaa
//aab
//aba
void PrintWords(string alf, int lengthWord, string currentWord)
{
    if (lengthWord == 0) Console.WriteLine($"{currentWord}");
    else
    {
        for (int i = 0; i < alf.Length; i++)
        {
            PrintWords(alf, lengthWord - 1, currentWord + alf[i]); 
            // мы добавили 1 букву currentWord + alf[i] и уменьшили в lengthWord - 1
        }
    }
}
PrintWords("abcd", 2, "");
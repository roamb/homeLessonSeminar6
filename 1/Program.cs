Console.WriteLine("Введите несколько чисел больше либо меньше нуля, используя пробел ");
string input = Console.ReadLine();
string[] inNum = input.Split(' ');
int sum = 0;
for (int i = 0; i < inNum.Length; i++)
{
    int num = Int32.Parse(inNum[i]);
    if (num > 0) sum++;
}
Console.WriteLine("Чисел больше 0: " + sum);
//Напишите программу, которая будет принимать на вход
//число и возвращать сумму его цифр.






string s = Console.ReadLine();
int summ = 0;
for (int i = 0; i < s.Length; i++)
{
    if (char.IsNumber(s[i]))
    {
        summ += Convert.ToInt32(s[i].ToString());
    }
}
Console.WriteLine(summ);

//=======================================================

//Напишите программу, которая на вход принимает два числа A и B,
//и возводит число А в целую степень B с помощью рекурсии.

// int APowerB(int a, int b)
// {   
//     if (b == 0) return 1;
//     else return APowerB(a, b - 1) * a;
    
// } 

// Console.WriteLine(APowerB(2, 5));

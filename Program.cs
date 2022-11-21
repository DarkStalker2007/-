/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*int Digits (int num)
{
    int dec = num%100;
    int win = dec/10;
    return win;
}


Console.WriteLine("Input your 3digit number:  ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int res = Digits(usernumber);

Console.WriteLine($"The second digit is {res}");
*/


void Digits(int usenam)

{

while 

 if (usenum<100){
    Console.WriteLine("Число не трёхзначное");
 }

else 
(usenum>999){
usenum/10
}



int num1 = usenum % 10;

 if (num<=99){
 Console.WriteLine("Число не трёхзначное");
 }
else 
{
    Console.WriteLine($"{num1}");
}


}

Console.WriteLine("Input your digit:  ");
int usenum = Convert.ToInt32(Console.ReadLine());
Digits(usenum);









/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*void Digits (int week)

{   
    int b=5;

   if (week>b){
   Console.WriteLine("Этот день выходной!");
   }
   
   else
   Console.WriteLine("Этот день будний!");
}

Console.WriteLine("Input your digit:  ");
int user_number = Convert.ToInt32(Console.ReadLine());
Digits(user_number);
*/
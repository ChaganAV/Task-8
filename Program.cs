// See https://aka.ms/new-console-template for more information
Console.Write("Введите число больше 0: ");
string? sNum = Console.ReadLine();

int num = Convert.ToInt32(sNum);
int min = 1;
while(min <= num)
{
    if (min%2 == 0)
        Console.WriteLine(min);

    min++;
}
    

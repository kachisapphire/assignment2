using System.Reflection.Emit;
using assignment2;

int i;

for (i = 2; i <= 50; i += 2)
{
    Console.WriteLine(i);
}

Label:
Console.WriteLine("Enter a number from 1-7");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Today is Sunday");
        break;
    case 2:
        Console.WriteLine("Today is Monday");
        break;
    case 3:
        Console.WriteLine("Today is Tuesday");
        break;
    case 4:
        Console.WriteLine("Today is Wednesday");
        break;
    case 5:
        Console.WriteLine("Today is Thursday");
        break;
    case 6:
        Console.WriteLine("Today is Friday");
        break;
    case 7:
        Console.WriteLine("Today is Saturday");
        break;
    default:
        Console.WriteLine("This is not a valid number");
        goto Label;
}

Myname newname = new Myname("Esther", "Michael");
newname.Myfullname();
Console.ReadKey();
using System.Security.Cryptography;
using BashSomeDudes;
using BigBad;

LittleDude boiGuy = new();
BadPeople waltuh = new();
BadPeople bigWaltuh = new();
boiGuy.hp = 100;
boiGuy.dmgReduction = 80;
waltuh.hp = 100;
waltuh.dmgReduction = 80;
bigWaltuh.hp = 100;
bigWaltuh.dmgReduction = 80;
string CryptographicUnexpectedOperationException = "";
while(bigWaltuh.hp > 1 && boiGuy.hp > 1)
{
    if(waltuh.hp <= 0)
    {
        Console.WriteLine($"(Enemy)BigWaltuh hp:{bigWaltuh.hp}");
        Console.WriteLine($"(You)Unimportant peasant hp:{boiGuy.hp}");
        Console.WriteLine("Attack or be frend (y/n)");
        CryptographicUnexpectedOperationException = Console.ReadLine().ToLower();
        if(CryptographicUnexpectedOperationException == "y")
        {
            Console.WriteLine("you is bad");
            bigWaltuh.hp -= 20;
            boiGuy.hp -= 10;
        }
        else
        {
            Console.WriteLine("stoopid!");
            boiGuy.hp -= 10;
        }
    }

    if(waltuh.hp > 1 && boiGuy.hp > 1)
    {
        Console.WriteLine($"(Enemy)Waltuh hp:{waltuh.hp}");
        Console.WriteLine($"(You)Unimportant peasant hp:{boiGuy.hp}");
        Console.WriteLine("Attack or be frend (y/n)");
        CryptographicUnexpectedOperationException = Console.ReadLine().ToLower();
        if(CryptographicUnexpectedOperationException == "y")
        {
            Console.WriteLine("you is bad");
            waltuh.hp -= 20;
            boiGuy.hp -= 1;
        }
        else
        {
            Console.WriteLine("stoopid!");
            boiGuy.hp -= 10;
        }
    }
}
Console.ReadLine("y wn cngrts!!!!")


Console.ReadLine();
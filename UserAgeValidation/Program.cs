// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanus
//kui kasutaja vanus on väiksem kui 13, siis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "welcome to Instagram"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {userAgeNum}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram");
    }
}
else
{
    Console.WriteLine("Could not read your age");
}
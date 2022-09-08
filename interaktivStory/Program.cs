bool pick = false;
string stayOrBack = "You decide to stay in";

Console.WriteLine("You wake up in the middle of the night, what do you do?");
Thread.Sleep(500);
Console.WriteLine("Walk outside(1)\nStay in your room(2)");

choice();
if (pick)
{
    outside();
}
else
{
    room();
}


void outside()
{
    Console.Clear();
    Console.WriteLine("You walk out into the darkness...");
    Thread.Sleep(2000);
    Console.WriteLine("...");
    Thread.Sleep(1000);
    Console.WriteLine("You can't see anything, why did you walk outside?!");
    Thread.Sleep(1000);
    Console.WriteLine("Go back inside(1)\nGo further into the darkness(2)");
    choice();
    if (pick)
    {
        stayOrBack = "You go back to";
        room();
    }
    else
    {
        Console.WriteLine("You walk further into the darkness and no longer know where you are.");
    }
}

void room()
{
    Console.Clear();
    Console.WriteLine($"{stayOrBack} your room, what do you want to do now?");
    Thread.Sleep(500);
    Console.WriteLine("Go back to sleep(1)\nPlay games all night(2)");
    choice();
    if (pick)
    {
        sleep();
    }
    else
    {
        gaming();
    }
}

void sleep()
{
    Console.Clear();
    Console.WriteLine("You go back to sleep..");
    for (var i = 0; i < 3; i++)
    {
        Thread.Sleep(1000);
        Console.Write("Z");
    }
    Console.WriteLine();
}

void gaming()
{
    Console.WriteLine("You decided that it was a good idea to play games all night.");
    Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
    for (var i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine("▓▒░");
        Thread.Sleep(100);
        Console.Clear();
        Console.WriteLine("░▓▒");
        Thread.Sleep(100);
        Console.Clear();
        Console.WriteLine("▒░▓");
        Thread.Sleep(100);
        Console.Clear();
        Console.WriteLine("▒▓░");
        Thread.Sleep(100);
    }
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.WriteLine("Your computer has unfortunately crashed because of an infinite loop.");
}

void choice()
{
    while (true)
    {
        string option = Console.ReadLine();
        if (option == "1")
        {
            pick = true;
            break;
        }
        else if (option == "2")
        {
            pick = false;
            break;
        }
        else
        {
            Console.WriteLine("enter a valid choice");
        }
    }
}

Thread.Sleep(1000);
Console.WriteLine("The End.");
Console.ReadLine();
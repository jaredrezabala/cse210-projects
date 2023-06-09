using System;
class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

string choice = "0";
while (choice != "4")
{
    Console.WriteLine("Menu Options:");
    Console.WriteLine("1. Start breathing activity");
    Console.WriteLine("2. Start reflecting activity");
    Console.WriteLine("3. Start Listing Activity");
    Console.WriteLine("4. Quit");
    Console.WriteLine();
    Console.WriteLine("Select a choice from the menu:");
    choice = Console.ReadLine();

    if (choice == "1")
    {
        breathingActivity.DisplayMessage();
    }
    else if (choice == "2")
    {
        reflectingActivity.DisplayMessage();
    }
    else if (choice == "3")
    {
        listingActivity.DisplayMessage();
    }
    else if (choice == "4")
    {
        Console.WriteLine("See you later");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please select a valid option.");
    }

    Console.WriteLine(); // Imprimir una línea en blanco para separar las iteraciones del menú
}

    }
}
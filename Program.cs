
// start main //

int userChoice = GetUserChoice(); //priming read

 //pre-test loop
 while(userChoice != 3) //condition check
 {
     RouteEm(userChoice);
     userChoice = GetUserChoice(); //update read
}

// end main //

static int GetUserChoice() 
{ 
    DisplayMenu();
    string userChoice=System.Console.ReadLine();
    if (IsValidChoice(userChoice))
    {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu()
{
   Console.Clear();
   System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput)
{
    if (userInput=="1" || userInput=="2" || userInput=="3")
    {
        return true;
    }
    return false;
}

static void SayInvalid()
{
    System.Console.WriteLine("Invalid choice");
    PauseAction();
}


//displays the full triangle for the bonus points Jeff stated in class
static void GetFull()
{
    Random rnd = new Random();
    int number = rnd.Next(3, 10);
    for (int i=1; i <= number; i++)
    {
        for (int j = 1; j <= number - i; j++)
        {
            Console.Write(" ");
        }
        for (int k=1; k<=2 * i -1; k++)
        {
            Console.Write("o");
        }
        Console.WriteLine();
    }
    PauseAction();
}


static void GetPartial()
{
    Random rnd = new Random();
    int number = rnd.Next(3, 10);
    for (int i=1; i <= number; i++)
    {
        for (int j = 1; j <= number - i; j++)
        {
            Console.Write(" ");
        }
        for (int k=1; k<=2 * i -1; k++)
        {
            if (rnd.Next(0,2) ==1)
            {
                Console.Write("o");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    PauseAction();
}

static void RouteEm(int menuChoice)
{
    if (menuChoice==1)
    {
        GetFull();
    }
    else if (menuChoice==2)
    {
        GetPartial();
    }
    else if (menuChoice!=3)
    {
        SayInvalid();
    }
}

static void PauseAction()
{
    System.Console.WriteLine("Press any key to continue...");
    System.Console.ReadKey();
}

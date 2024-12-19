using System;
namespace ConsoleApp1
{
    public static class Program
    {
        static bool mainLoop = true;
        static void Main(string[] args)
        {
            Idk i = new Idk();
            Story story = new Story();
            while (mainLoop)
            {
                try
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Welcome to Duels of Destiny!");
                    Console.WriteLine("[1] New Game");
                    Console.WriteLine("[2] Load Game");
                    Console.WriteLine("[3] Campaign Mode");
                    Console.WriteLine("[4] Credits");
                    Console.WriteLine("[5] Exit");
                    Console.WriteLine("----------------------------------------");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:

                            i.CharacterCustomization();
                            break;
                        case 2:
                            Idk.DataBase();
                            break;
                        case 3:
                            story.Display();
                            break;
                        case 4:
                            story.Display(choice);
                            break;
                        case 5:
                            Console.WriteLine("Farewell. Now, face your destiny");
                            return;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }





                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("Error: " + e.Message);
                    Console.WriteLine("Try again");
                }
            }

        }
        public static void GoBackToMenu()
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Would you like to go back to menu? Y/N");
                Console.WriteLine("----------------------------------------");

                string userinput = Console.ReadLine();
                if (!(userinput.Equals("Y", StringComparison.OrdinalIgnoreCase) || userinput.Equals("N", StringComparison.OrdinalIgnoreCase)))
                {
                    Console.Clear();

                    Console.WriteLine("Invalid Selection, Try again");
                        
                }
                else if (userinput.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    break;

                }

                if (userinput.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Console.WriteLine("Farewell. Now, face your destiny");
                    mainLoop = false;
                    break; 
                }
            }
        }
    }

}

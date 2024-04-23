using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;


namespace Komodo_Console;

public class ProgramUI
{
    
    public void Run()
    {
        
    }

    //Here's where I add the code for the Menu.
    private void Menu()
    {
        bool keepRunning = true;
        {
            //Displaying the options to the user here...
            System.Console.WriteLine("Welcome to the Komodo Development Teams Mamagement App. Select a menu option:\n"+
                "1. Add New Developer\n" +
                "2. View Developers\n" +
                "3. Add Developement Team\n" +
                "4. Add Developement Team Member\n" +
                "5. Update Development Team\n" +
                "6. Delete Developer\n" +
                "7. Delete Development Team\n" +
                "8. Exit App");
            
            //Now we get the user's input here...
            string input = Console.ReadLine();

            //Now we will evaluate the user's input and act accordingly...
            switch (input)
            {
                case "1":
                    CreateNewDeveloper();
                    break;
                case "2":
                    ViewDeveloper();
                    break;
                case "3":
                    CreateNewDevTeam();
                    break;
                case "4":
                    AddDevTeam();
                    break;
                case "5":
                    UpdateDevTeam();
                    break;
                case "6":
                    DeleteDeveloper();
                    break;
                case "7":
                    DeleteDevTeam();
                    break;
                case "8":
                    //Exiting the app and getting the heck outta there! Buh-bye!
                    System.Console.WriteLine("Goodbye.");
                    keepRunning = false;
                    break;
                default:
                    System.Console.WriteLine("Sorry. That is not a valid number. Please try again.");
                    break;
                }

                System.Console.WriteLine("Please press any key to continue...");
                System.Console.ReadKey();
                System.Console.Clear();
                }
    }
}
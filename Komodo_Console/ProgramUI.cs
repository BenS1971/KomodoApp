


namespace KomodoUI
{
    public class ProgramUI
    {
        private readonly object _Developer_Repo;

        public object Newdevloper { get; private set; }

        public static void Run()
        {

        }

        //Here's where I add the code for the Menu.
        private void Menu()
        {
            {
                //Displaying the options to the user here...
                Console.WriteLine("Welcome to the Komodo Development Teams Mamagement App. Select a menu option:\n"+
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
                        CreateDeveloper();
                        break;
                    case "2":
                        ViewDeveloper();
                        break;
                    case "3":
                        UpdateDeveloper();
                        break;
                    case "4":
                        CreateNewDevTeam();
                        break;
                    case "5":
                        ViewDevTeam();
                        break;
                    case "6":
                        UpdateDevTeam();
                        break;
                    case "7":
                        DeleteDeveloper();
                        break;
                    case "8":
                        DeleteDevTeam();
                        break;
                    case "9":
                        //Exiting the app and getting the heck outta there! Buh-bye!
                        Console.WriteLine("Goodbye.");
                        break;
                    default:
                        Console.WriteLine("Sorry. That is not a valid number. Please try again.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void DeleteDevTeam()
        {
            throw new NotImplementedException();
        }

        private void DeleteDeveloper()
        {
            throw new NotImplementedException();
        }

        private void UpdateDeveloper()
        {
            throw new NotImplementedException();
        }

        //Create a new Developer...
        private void CreateDeveloper()
    {
        Console.Clear();
        CreateDeveloper newContent = CreateDeveloper();
        _Developer_Repo.AddContentToList(Newdevloper)
    }

        private CreateDeveloper()
        {
            throw new NotImplementedException();
        }

        //View a developer...

        private void ViewDeveloper()
        {
            Console.Clear();

            Console.WriteLine("Enter the I.D. number of the developer you would like to see:");
            int Developer_ID_Number = Console.Read();
            var content = Developer_ID_Number.ToString();
        }
        private void UpdateDeveloper;
        {

        }
        private void CreateNewDevTeam()
        {

        }

        private void ViewDevTeam()
        {
            Console.Clear();
        }

        private void UpdateDevTeam()
        {
            Console.Clear();
        }

        private class CreateDeveloper
        {
        }


    }

}

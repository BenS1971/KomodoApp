using DeveloperRepo.Repository;



namespace KomodoUI
{
    public class ProgramUI
    {
        private readonly DeveloperRepoRepository _devRepo = new();

        public object? Newdevloper { get; private set; }

        public static void Run()
        {

        }

        //Here's where I add the code for the Menu.
        private void Menu()
        {
            {
                //Displaying the options to the user here...
                Console.WriteLine("Welcome to the Komodo Development Teams Mamagement App. Select a menu option:\n" +
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

        private void UpdateDevTeam()
        {
            Console.WriteLine("Please choose a Dev Team to update:");
            Console.ReadLine();
        }

        private void ViewDevTeam()
        {
            Console.WriteLine("Please choose a Dev Team to View.");
            Console.ReadLine();
        }

        private void CreateNewDevTeam()
        {
            Console.WriteLine("Please create a new Dev by entering the dev team name:");
        }

        private static void DeleteDevTeam()
        {
            Console.WriteLine("\nEnter the name of the Dev Team you want to delete:");
            string input = Console.ReadLine();

            bool wasDeleted = DevTeamRepo.RemoveContentFromList(input);

            if (wasDeleted)
            {
                Console.WriteLine("The Dev team was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The Dev Team could not be deleted.");
            }
        }
        private void DeleteDeveloper()
        {
            {
                Console.WriteLine("\nEnter the ID number and last name of the developer you want to delete:");
                string input = Console.ReadLine();

                bool wasDeleted = _Developer_Repo.DeleteDeveloper(input);

                if (wasDeleted)
                {
                    Console.WriteLine("The Developer was successfully deleted.");
                }
                else
                {
                    Console.WriteLine("The Developer could not be deleted.");
                }
            }

        }
        // Here is where we can update a developer...

        private static void UpdateDeveloper()
        {
            DisplayAllDevelopers();

            Console.WriteLine("Please choose a deeveloper to update.");
            UpdateDeveloper newContent = UpdateDeveloper();
        }

        // Display all of your developers here...

        private static void DisplayAllDevelopers()
        {
            throw new NotImplementedException();
        }

        //Create a new Developer...
        private void CreateDeveloper()
        {
            Console.Clear();

            Console.WriteLine("Please enter a Developer Number for new developer:");
            CreateDeveloper newContent = CreateDeveloper();
        }

        //View a developer...

        private static void ViewDeveloper()
        {
            Console.Clear();

            Console.WriteLine("Enter the I.D. number of the developer you would like to see:");
            int Developer_ID_Number = Console.Read();
            string content = Developer_ID_Number;
        }

         // Here we will create a new Dev Team...
        private void CreateNewDevTeam()
        {
            Console.Clear();

            ViewDevTeam newContent = CreateNewDevTeam();
            DevTeamRepo.AddNewContentToList(newContent);
        }
        // Let's view a Dev Team right here, okay? Wouldn't that be lovely?
        private void ViewDevTeam()
        {
            Console.Clear();

            Console.WriteLine("Enter the I.D. number of the dev team you would like to see:");
            _ = Console.Read();
        }
        // Now we will update the Dev Team(s) here...

        private void UpdateDevTeam()
        {
            Console.Clear();

            DisplayAllDevTeams();

            Console.WriteLine("Please choose a deeveloper to update.");
            UpdateDevTeam newContent = UpdateDevTeam();
        }

        // ...And finally, last but not least, the Seed Content. (Maybe.)

        private object SeedContentList()
        {
            _Developer_Repo.AddContentToList;
        }
    }
}
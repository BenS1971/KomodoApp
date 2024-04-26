
namespace DeveloperRepo.Repository
{


    // Below, we have the POCOs (Plain Ol' C-Sharp Objects) for the Komodo Developers. 

    public class Developer

    {
        internal static object? lastName;

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int DeveloperIDNumber { get; set; }
        public bool PluralsightAccess { get; set; }

    }
}

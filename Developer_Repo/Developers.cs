namespace Developer_Repo.Repository;


// Below, we have the POCOs (Plain Ol' C-Sharp Objects) for the Komodo Developers. 
// Please note the ID Number integers are  added to minimize confusion. 
public class Developers
{
    internal static object lastName;

    public required string FirstName { get; set;}
    public required string LastName { get; set; }
    public int DeveloperIDNumber { get; set;}
    public bool PluralsightAccess { get; set; }

}

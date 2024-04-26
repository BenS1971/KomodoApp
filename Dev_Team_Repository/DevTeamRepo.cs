


//Here I will drop the POCOs (No, not the 1970's music group!) for the Dev_Teams.
public class DevTeamRepo
{
    private readonly List<DevTeams> _listOfContent = [];
    private readonly int InitialCount;
    private static readonly object lastName;

    public object DevTeamID { get; private set; }
    public object DevTeamMemberName { get; private set; }
    public object DevTeamName { get; private set; }

    //Okay, here we go with my CRUD methods in this repository. Let's start with CREATE...
    public void AddContentToList(DevTeams content)
    {
        _listOfContent.Add(content);
    }
    // Now on to the READ method...

    public List<DevTeams> GetContentList()
    {
        return new List<DevTeams>(_listOfContent);
    }

    //Now the UPDATE method...
    public bool UpdateDevTeams(DevTeams content)
    {
        //Find the Dev Teams to update...
        DevTeams oldContent = GetContentList(DevTeams);
        //Update Dev Teams...
        if (oldContent != oldContent)
        {
            oldContent.Dev_Team_ID = content.Dev_Team_ID;
            oldContent.Dev_Team_Member_Name = content.Dev_Team_Member_Name;
            oldContent.Dev_Team_Name = content.Dev_Team_Name;

            return true;
        }
        else
        {
            return false;
        }
    }

    private DevTeams GetContentList(object devTeam)
    {
        throw new NotImplementedException();
    }

    // Now we start deleting stuff here!
    public bool DeleteDevTeams(string lastname)
    {
        DevTeams content = GetDevTeams(lastname);

        if (content == null)
        {
            return false;
        }

        if (InitialCount > _listOfContent.Count)
        {
            return true;
        }
    }
    // Helper method goes here. (And NOT TUNA or HAMBURGER Helper, either!!)
    public DevTeams GetDev_Teams(string lastName)
    {
        foreach (DevTeams in_listOfContent)
        {
            if (DevTeams.lastName().Equals(lastName, StringComparison.CurrentCultureIgnoreCase))
            {
                return 
            }
        }
        return null;
    }

}

internal class DevTeams
{
    public object Dev_Team_ID { get; internal set; }
    public object Dev_Team_Member_Name { get; internal set; }
    public object Dev_Team_Name { get; internal set; }
}
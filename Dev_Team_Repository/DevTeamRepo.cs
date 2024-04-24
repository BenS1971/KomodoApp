using Dev_Team;

//Here I will drop the POCOs (No, not the 1970's music group!) for the Dev_Teams.
public class Dev_Teams
{
    private List<Dev_Teams>  _listOfContent = new List<Dev_Teams>();
    private int InitialCount;
    private static object lastName;

    public object Dev_Team_ID { get; private set; }
    public object Dev_Team_Member_Name { get; private set; }
    public object Dev_Team_Name { get; private set; }

    //Okay, here we go with my CRUD methods in this repository. Let's start with CREATE...
    public void AddContentToList(Dev_Teams content)
    {
         _listOfContent.Add(content);    
    }
    // Now on to the READ method...

    public List<Dev_Teams> GetContentList()
    {
        return new List<Dev_Teams>(_listOfContent);
    }

    //Now the UPDATE method...
    public bool UpdateDev_Teams(Dev_Teams content)
    {
        //Find the Dev Teams to update...
        Dev_Teams oldContent = GetContentList(Dev_Teams);
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
    // Now we start deleting stuff here!
    public bool DeleteDev_Teams(string lastname)
    {
        Dev_Teams content = GetDev_Dev_Teams(lastname);    

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
    public Dev_Teams GetDev_Teams(string lastName)
    {
        foreach (Dev_Teams in_listOfContent)
        {
            if (Dev_Teams.lastName().Equals(lastName, StringComparison.CurrentCultureIgnoreCase))
            {
                return content;
            }
        }
        return null;
    }

}
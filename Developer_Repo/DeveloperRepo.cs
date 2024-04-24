using System.ComponentModel;
using System.Net.Mime;

namespace Developer_Repo.Repository;

public class Developer_RepoRepository
{
    private List<Developers>  _listOfContent = new List<Developers>();

    //Okay, here we go with my CRUD methods in this repository. Let's start with CREATE...
    public void AddContentToList(Developers content)
    {
         _listOfContent.Add(content);    
    }
    // Now on to the READ method...

    public List<Developers> GetContentList()
    {
        return new List<Developers>(_listOfContent);
    }

    //Now the UPDATE method...
    public bool UpdateDeveloper(Developers content)
    {
        //Find the developers to update...
        Developers oldContent = GetContentList(Developers);
        //Update Developers...
        if (oldContent != oldContent)
        {
            oldContent.Developer_ID_Number = content.Developer_ID_Number;
            oldContent.FirstName = content.FirstName;
            oldContent.LastName = content.LastName;
            oldContent.Pluralsight_Access = content.Pluralsight_Access;

            return true;
        }
        else
        {
            return false;
        }
    }
    // Now we start deleting stuff here!
    public bool DeleteDeveloper(string lastname)
    {
        Developers content = GetContentList(lastname);    

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
    public Developers GetDevelopers(string lastName)
    {
        foreach (Developers in _listOfContent)
        {
            if (Developers.lastName.ToLower() == lastName.ToLower())
            {
                return content;
            }
        }
        return null;
    }
}
using System.Net.Mime;

namespace Developer_Repo.Repository;

public class Developer_RepoRepository
{
    private List<Developers>  _listOfContent = new List<Developers>();

    //Okay, here we go with my CRUD methods in this repository. Let's start with CREATE...
    public void AddContentToList(Developer_RepoRepository content)
    {
         _listOfContent.Add();    
    }
    // Now on to the READ method...

    public List<Developers> GetContentList()
    {
        return new List<Developers>(_content);
    }

    //Now the UPDATE method...

}
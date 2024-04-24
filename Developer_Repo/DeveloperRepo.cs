

namespace Developer_Repo.Repository
{
    public class DeveloperRepoRepository
    {
#pragma warning disable IDE0028 // Simplify collection initialization
        private readonly List<Developers> _listOfContent = new();

        public int InitialCount { get; private set; }
#pragma warning restore IDE0028 // Simplify collection initialization

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
                oldContent.DeveloperIDNumber = content.DeveloperIDNumber;
                oldContent.FirstName = content.FirstName;
                oldContent.LastName = content.LastName;
                oldContent.PluralsightAccess = content.PluralsightAccess;

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
}
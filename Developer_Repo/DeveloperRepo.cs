namespace DeveloperRepo.Repository
{
    public class DeveloperRepoRepository
    {

        private readonly List<Developer> _listOfContent = [];

        public int InitialCount { get; private set; }


        //Okay, here we go with my CRUD methods in this repository. Let's start with CREATE...
        public void AddContentToList(Developer content)
        {
            _listOfContent.Add(content);
        }
        // Now on to the READ method...

        public List<Developer> GetContentList(string lastname)
        {
            return new List<Developer>(_listOfContent);
        }

        //Now the UPDATE method...
        public static bool UpdateDeveloper(Developer content)
        {
            //Find the developers to update...
            Developer oldContent = GetContentList(Developer);
            //Update Developers...
            if (oldContent == null)
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
        public Developers? GetDevelopers(string lastName)
        {
            foreach (Developers in _listOfContent)
            {
                if (Developers.lastName.Equals(lastName))
                {
                    return
                }
            }
            return null;
        }
    }
}




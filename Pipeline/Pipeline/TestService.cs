using Pipeline.Models;

namespace Pipeline
{
    public class TestService
    {
        public string PluralChecker(int count)
        {

            if (count == 1)
                return $"Clicked {count} time";
            else
                return $"Clicked {count} times";

        }

        public List<Book> GetBooks()
        {
            using (var context = new BookDb())
            {
                return context.Petitions.ToList();
            }
        }
            
    }
}

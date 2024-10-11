using Pipeline.Models;
using static Pipeline.TestService;

namespace Pipeline
{
    public partial class MainPage : ContentPage
    {
        TestService testService = new TestService();
        int index = 0;
        List<Book> books;


        public MainPage()
        {
            InitializeComponent();
            this.books = testService.GetBooks(); 
        }

        private void OnNextBtnClicked(object sender, EventArgs e)
        {
            this.index++;

            if (this.index >= this.books.Count) { this.index = 0; }

            Title.Text = this.books[this.index].Name;
            Blurb.Text = this.books[this.index].Blurb;
            Author.Text = this.books[this.index].Author;

        }
    }

}

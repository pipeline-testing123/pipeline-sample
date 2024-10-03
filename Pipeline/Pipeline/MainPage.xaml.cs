using static Pipeline.TestService;

namespace Pipeline
{
    public partial class MainPage : ContentPage
    {
        TestService testService = new TestService();
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            CounterBtn.Text = testService.PluralChecker(count);


            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}

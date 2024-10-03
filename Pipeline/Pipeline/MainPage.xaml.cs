using static Pipeline.TestService;

namespace Pipeline
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public string PluralChecker(int count)
        {

            if (count == 1)
                return $"Clicked {count} time";
            else
                return $"Clicked {count} times";

        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            CounterBtn.Text = this.PluralChecker(count);


            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}

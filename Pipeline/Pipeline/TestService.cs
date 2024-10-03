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
    }
}

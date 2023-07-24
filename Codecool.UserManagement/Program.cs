namespace Codecool.UserManagement;

internal class Program
{
    public static void Main(string[] args)
    {
        string[] names = { "John", "Alexa", "Kyle" };
        int[] ages = { 20, 25, 40 };
        Gender[] genders = { Gender.Male, Gender.Female, Gender.Male };
    }

    #region Summary

    private static string Summarize(string name, int age, Gender gender)
    {
        //TODO: implement
        return null;
    }

    private static string[] Summarize(string[] names, int[] ages, Gender[] genders)
    {
        //TODO: implement
        return null;
    }

    private static void DisplaySummary(string summary)
    {
        //TODO: implement
    }

    private static void DisplaySummary(string[] summaries)
    {
        //TODO: implement
    }

    #endregion

    #region Update Age

    private static void UpdateAge(int index, int[] ages, int newAge)
    {
        //TODO: implement
    }

    #endregion

    #region User Input

    private static string GetInput()
    {
        //TODO: implement
        return null;
    }

    private static bool ParseInput(string input, out int number)
    {
        //TODO: implement
        return false;
    }

    private static int AskForIndex(int max)
    {
        //TODO: implement
        return 0;
    }

    private static bool AskIfUpdateAge()
    {
        //TODO: implement
        return false;
    }

    private static int AskForNewAge()
    {
        //TODO: implement
        return 0;
    }

    #endregion

}
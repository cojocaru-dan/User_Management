namespace Codecool.UserManagement;

internal class Program
{
    public static void Main()
    {
        string[] names = { "John", "Alexa", "Kyle" };
        int[] ages = { 20, 25, 40 };
        Gender[] genders = { Gender.Male, Gender.Female, Gender.Male };
        for (int i = 0; i < 3; i++)
        {   
            string summarizeSentence = Summarize(names[i], ages[i], genders[i]);
            DisplaySummary(summarizeSentence);
        }

        string[] arr = Summarize(names, ages, genders);
        DisplaySummary(arr);

        if (AskIfUpdateAge()) 
        {
            int userIndex = AskForIndex(names.Length);
            int userAge = AskForNewAge();
            UpdateAge(userIndex, ages, userAge);
        }
        DisplaySummary(Summarize(names, ages, genders));
    }

    #region Summary

    private static string Summarize(string name, int age, Gender gender)
    {
        //TODO: implement
        return $"{name} [{gender}] - {age} years old";
    }

    private static string[] Summarize(string[] names, int[] ages, Gender[] genders)
    {
        string[] arr = new string[3];
        //TODO: implement
        for (int i = 0; i < 3; i++)
        {   
            arr[i] = $"{names[i]} [{genders[i]}] - {ages[i]} years old";   
        }
        return arr;
    }

    private static void DisplaySummary(string summary)
    {
        //TODO: implement
        Console.WriteLine(summary);
    }

    private static void DisplaySummary(string[] summaries)
    {
        //TODO: implement
        for (int i = 0; i < summaries.Length; i++)
        {
            Console.WriteLine($"{i+1}: {summaries[i]}");
        }
    }

    #endregion

    #region Update Age

    private static void UpdateAge(int index, int[] ages, int newAge)
    {
        //TODO: implement
        ages[index] = newAge;
    }

    #endregion

    #region User Input

    private static string GetInput()
    {
        //TODO: implement
        return Console.ReadLine() ?? string.Empty;
    }

    private static int ParseInput(string input, out int number)
    {
        //TODO: implement
        number = Int32.Parse(input);
        return number;
    }

    private static int AskForIndex(int max)
    {
        //TODO: implement
        Console.Write("What index do you want to update? ");
        string indexInput = GetInput();
        try
        {
            ParseInput(indexInput, out int parsedInput);
            if (parsedInput >= 0 && parsedInput <= max-1) return parsedInput;
            else throw new IndexOutOfRangeException("The index must be between 0 and 2.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return AskForIndex(max);
        }
    }

    private static bool AskIfUpdateAge()
    {
        //TODO: implement
        Console.Write("Do you want to update age? Yes/No ");
        string ageInput = GetInput();
        return ageInput == "Yes";
    }

    private static int AskForNewAge()
    {
        //TODO: implement
        Console.Write("Type new age: ");
        string ageInput = GetInput();
        try 
        {
            ParseInput(ageInput, out int parsedAgeInput);
            return parsedAgeInput;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return AskForNewAge();
        }
    }

    #endregion

}
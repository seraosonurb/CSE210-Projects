using System;

class Program
{    private static string TEXT = @"Trust in the Lord with all your heart and do not lean on your own understanding; in all your ways acknowledge him, and he will make your paths straight";

    static void Main(string[] args)
    {
        
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, TEXT);
        string input = "not yet";

        while (input != "quit")
        {
            Console.Clear();
            if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWord(3);
            }
            Console.WriteLine(reference.GetDisplayReference() + scripture.GetDisplayText());
            input = Console.ReadLine();

            if (scripture.IsCompletelyHidden() == true)
            {
                
                break;
            }

        }

        
    }
}
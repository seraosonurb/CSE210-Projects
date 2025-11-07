using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();
        DateTime date = DateTime.Now;

        int userChoice = 0;
        do
        {
            Entry entry = new Entry();

            journal.DisplayMenu();
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                entry._date = date.ToShortDateString() ;
                entry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (userChoice == 2)
            {
                journal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                journal.LoadFromFile();
            }
            else if (userChoice == 4)
            {
                journal.SaveToFile();
            }
            else if (userChoice == 5)
            {
                break;
            }
            

        } while (userChoice != 5);
        
        
    }   
}
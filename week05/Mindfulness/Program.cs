using System;

class Program
{
    static void Main(string[] args)
    {
        int input = 0;
        do
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());
            while(input != 4)
        {
            if(input == 1)
            {
                Console.Clear();
                Breathing breathing = new Breathing();
                breathing.Run(); 
                break;            
            }
            else if(input == 2)
            {
                Console.Clear();
                Reflecting reflecting = new Reflecting();
                reflecting.Run();
                break;            
            }
            else if(input == 3)
            {
                Console.Clear();
                Listing listing = new Listing();
                listing.Run();
                break;            
            }
        }

        }while(input != 4 );
    
    }

}
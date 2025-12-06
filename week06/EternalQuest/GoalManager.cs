public class GoalManager{

    private List<IGoal> _goals = new List<IGoal>();
    private int _score;
    public GoalManager()
    {
       _score = 0;
    }
    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                ListGoalNames();
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your have: {_score} points.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
    }
    public void CreateGoal()
    {
        string _input = "";
        Console.Write("What type of goal would you like to create? ");
        _input = Console.ReadLine();
        if (_input == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();       
            SimpleGoal simpleGoal = new SimpleGoal(name, description, int.Parse(points));
            _goals.Add(simpleGoal);
        }
        else if (_input == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine(); 
            EternalGoal eternalGoal = new EternalGoal(name, description, int.Parse(points));
            _goals.Add(eternalGoal);
        }
        else if (_input == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int amount = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, int.Parse(points), amount, bonus);
            _goals.Add(checklistGoal);
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        foreach(IGoal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void RecordEvent()
    {
        for (int i = 0; i < _goals.Count(); i++)
        {
            string number = (i + 1).ToString();
            Console.WriteLine($"{number}. {_goals[i].GetName()}");
        }
        Console.WriteLine("What goal have you completed? ");
        int _choice = int.Parse(Console.ReadLine());
        _goals[_choice - 1].RecordEvent();
        _score = _goals[_choice - 1].GetPoints() + _score;
        
        
    }
    public void SaveGoals()
    {
        string filename = "";
        Console.WriteLine("What is the filename?");
        filename = Console.ReadLine();
        using (StreamWriter outpuFile = new StreamWriter(filename))
        {
            outpuFile.WriteLine(_score);
            foreach (IGoal g in _goals)
            {
              outpuFile.WriteLine(g.GetDetailsString());
            }
        }
    }
    public void LoadGoals()
    {
        string filename = "";
        Console.Write("What is the file name? ");
        filename = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(filename);
        int totalScore = int.Parse(lines[0]);

    for (int i = 1; i < lines.Length; i++)
    {
        if (string.IsNullOrWhiteSpace(lines[i])) continue;

        string[] typeSplit = lines[i].Split(':');
        string type = typeSplit[0].Trim();
        string[] parts = typeSplit[1].Split(',');
        _score = totalScore;

        for (int p = 0; p < parts.Length; p++) parts[p] = parts[p].Trim();

        switch (type)
        {
            case "SimpleGoal":
                _goals.Add(new SimpleGoal(
                    parts[0],                      
                    parts[1],                      
                    int.Parse(parts[2])            
                ));
                break;

            case "EternalGoal":
                _goals.Add(new EternalGoal(
                    parts[0],
                    parts[1],
                    int.Parse(parts[2])
                ));
                break;

            case "ChecklistGoal":
                _goals.Add(new ChecklistGoal(
                    parts[0],
                    parts[1],
                    int.Parse(parts[2]),
                    int.Parse(parts[3]),           
                    int.Parse(parts[4])           
                ));       
                break;
        }
    }

}
}
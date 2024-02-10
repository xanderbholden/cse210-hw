public class CheckListGoal : Goal
{

    protected int _extrapoints;

     protected int _bonus;

     protected int _done;

    public CheckListGoal()
    {
        

    }

     public override void GetGoal()
    {
         Console.WriteLine("Start by naming your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("Please give a short description of the goal?");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal");
        _points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be completed for a bonus");
        _bonus = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus reward for achieiving your goal a certain number of times");
        _extrapoints = int.Parse(Console.ReadLine());

    }

    public override void PrintGoal()

    {
          {
           if (_check == false)
        {
            Console.Write("[]");
        }
        else
        {
            Console.Write("[x]");
            
        }
        Console.WriteLine($" {_check} {_name} ({_description}) --- Currently completed: {_done}/{_bonus} ");
         }
    }

    public override string SaveFile()
    {
        return $" Checklist Goal - {_name} - {_description} - {_points} - {_extrapoints} - {_bonus}";
    }

    public override void RecordEvent()
    {
         _answer = int.Parse(Console.ReadLine());
        if (_answer == 3)
        {   
            _check = true;
            _totalPoints =+ _points+_checklistPoints +_eternalPoints;
            Console.WriteLine($"Congratulations you earned {_points} points. Keep it up!");
            

        }
    }
}
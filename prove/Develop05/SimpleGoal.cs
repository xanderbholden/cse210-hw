public class SimpleGoal : Goal
{
    protected bool _complete = false;
     public SimpleGoal()
    {
        

    }


    public override string SaveFile()
    {
         
        return $" Simple Goal - {_name} - ({_description}) - {_points} - {_complete} ";
    
    }
}
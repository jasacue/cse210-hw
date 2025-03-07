public class BreathingActivity : Activity
{
    public BreathingActivity(string description, string name, string endDescription, int duration)
        :base(description, name, endDescription, duration)
        {
            _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
            _name = "Braeathing Activity";
            SetDuration();
        }
    public void BreathActive()
    {
        StartActivity();
        int i = 0;
        while (i < _duration/10)
        {
            Console.WriteLine("Breath In");
            Thread.Sleep(3000);
            PrintTimer(4);
            Console.WriteLine("Breath Out");
            Thread.Sleep(3000);
            PrintTimer(4);
            i++;
        }
        Console.WriteLine(_endMessage);
        
    }

        
}
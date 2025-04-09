public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        :base("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Braeathing Activity",
         "Thank you for taking some time to be mindufl", duration)
        {
            _duration = duration;
            SetDuration();
        }
    public void BreathActive()
    {
        StartActivity();
        int i = 0;
        while (i < (_duration+9)/10)
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
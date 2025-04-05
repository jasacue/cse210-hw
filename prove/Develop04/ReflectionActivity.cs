public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectionActivity(int duration)
        :base("This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection Activity", "Thank you for taking some time to be mindufl", duration)
        {
            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless.");
            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add("What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");
            SetDuration();
        }
    public void RefActive()
    {
        StartActivity();
        Random r = new Random();
        int z = 0;
        Thread.Sleep(2000);
        while (z < (_duration+7)/8)
        {
            int i = r.Next(0, _prompts.Count());
            Console.WriteLine($"{_prompts[i]} \n");
            Spinner(2);
            i = r.Next(0, _questions.Count());
            Console.WriteLine($"{_questions[i]} \n");
            Spinner(2);
            z ++;
        }
        Console.WriteLine(_endMessage);
    }

}
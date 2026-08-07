using System;

public class BreathingActivity : Activity
{
    private int _breathingInDuration;
    private int _breathingOutDuration;

    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _breathingInDuration = 4;
        _breathingOutDuration = 6;
    }

    public override void Start()
    {
        DisplayWelcomeMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountdown(_breathingInDuration);
            Console.WriteLine();

            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write("Breathe out...");
            ShowCountdown(_breathingOutDuration);
            Console.WriteLine();
        }

        DisplayEndMessage();
    }
}

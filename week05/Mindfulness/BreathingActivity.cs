using System;
using System.Diagnostics;
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
    SetName("Breathing Activity");
        SetDescription("This is a breathing activity to help you relax and focus.");
    }

        public void PreformBreathingActivity()
        {
            int duration = GetDuration(); //Grabs duration from Activity class
            int elapsedTime = 0; //Keep track of time
            int breathingCycleTime = 4; //Time for breathing "in" and "out" in seconds

            while (elapsedTime < duration)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(breathingCycleTime); //Show countdown for breathing in
                elapsedTime += breathingCycleTime;

                if (elapsedTime >= duration) break; //if time is over the requested amount, break loop

                Console.WriteLine("Breathe out...");
                ShowCountDown(breathingCycleTime); //same as above, but for breathing out
                elapsedTime += breathingCycleTime;
            }
        }

        public void StartBreathingSession()
        {
            StartingMessage();
            AskDuration();
            PreformBreathingActivity();
            EndingMessage();
        }
       
}


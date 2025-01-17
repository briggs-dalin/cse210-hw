using System;

public class PromptGenerator
{

    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What did you learn today that you didn't know before?",
            "What was something you did today that made yourself proud?",
            "How did you take care of yourself today?",
            "What challenges did you face today?",
            "If you could change one thing about today, what would it be?"
        };
    }

    public string GetRandomPrompt()
    {
        return "";
    }
}
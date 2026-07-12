using System;
using System.Collections.Generic;

class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What was the best part of my day ?");
        _prompts.Add("What made me smile today?");
        _prompts.Add("What challenge did I face and how did I handle it?");
        _prompts.Add("What am I grateful for today?");
        _prompts.Add("What did I learn today?");
        _prompts.Add("How did I show kindness to someone?");
        _prompts.Add("What is one goal I want to reach tomorrow?");
        _prompts.Add("What surprised me today?");
        _prompts.Add("What did I do to take care of myself?");
        _prompts.Add("What is one thing I would like to improve?");
        _prompts.Add("What memory from today do I want to remember?");
        _prompts.Add("What did I do that was brave today?");
        _prompts.Add("What inspired me today?");
        _prompts.Add("What is one thing I can let go of?");
        _prompts.Add("What did I learn about myself today?");
        _prompts.Add("What made me feel peaceful?");
        _prompts.Add("What is one thing I am proud of?");
        _prompts.Add("How did I spend my free time today?");
        _prompts.Add("What is one dream I want to work toward?");
        _prompts.Add("What did I do to help someone else?");
        _prompts.Add("What would make tomorrow better?");
        _prompts.Add("What is one habit I want to build?");
        _prompts.Add("What thought or feeling do I want to explore more?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomInt = random.Next(1, _prompts.Count + 1);

        return _prompts[randomInt];
    }
}
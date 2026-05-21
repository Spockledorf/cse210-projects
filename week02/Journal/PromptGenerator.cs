// Responsibility: Provides journal writing prompts. 
// Behavior: Stores a list of prompts and returns a random one when requested.
public class PromptGenerator
{
    private readonly List<string> _prompts = [
        "What is a moment you felt proud of yourself today, and what made it meaningful?",
        "What is something you heard today that made you think differently?",
        "What did you learn about your Savior, Jesus Christ, today?",
        "What challenged you today, and what did you learn from it?",
        "What's the best part of your day so far?",
        "What are three things that brought you peace or comfort today?",
        "What's one thing you're grateful for today, and why?",
        "How did you help your family feel cared about and seen today?",
        "What are you most excited for in the next 168 hours?",
        "What's something you've been thinking about a lot today?"
        ];

    public string GetRandomPrompt()
    {
        int randomIndex = Random.Shared.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
}

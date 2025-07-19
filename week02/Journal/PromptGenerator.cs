public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most challenging part of my day?",
        "What am I grateful for today?",
        "What words of encouragement would I give to a fellow student?",
        "Given the chance would I learn this again?",
        "What other topics of my stidy program am I enjoying?",
        "Am I confident enough to teach other students given the chance?",
        "Am I proud of the work I have put into my studies to date?",
        "What did I learn today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
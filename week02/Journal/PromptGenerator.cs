public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best moment of my day, and why?",
        "What are three qualities I admire in others — and how can I nurture them in myself?",
        "What habits are helping me grow — and which are holding me back?",
        "How do I show love to the people I care about?",
        "What story, idea, or image keeps coming back to me?"
    };
    
    Random random = new Random();
    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count());
        return _prompts[index];
    }


}
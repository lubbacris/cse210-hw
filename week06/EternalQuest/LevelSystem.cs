// CREATIVE ENHANCEMENT: Level progression system
// Tracks player level based on total points earned
// Awards titles at different level milestones
public class LevelSystem
{
    public int CurrentLevel { get; private set; } = 1;
    public int CurrentExperience { get; private set; } = 0;
    public string CurrentTitle => GetTitle(CurrentLevel);

    public int AddExperience(int points)
    {
        int initialLevel = CurrentLevel;
        CurrentExperience += points;
        
        // Level up every 1000 points
        CurrentLevel = 1 + (CurrentExperience / 1000);
        
        return CurrentLevel - initialLevel;
    }

    public void SetLevel(int level) => CurrentLevel = level;
    public void SetExperience(int exp) => CurrentExperience = exp;

    private string GetTitle(int level)
    {
        return level switch
        {
            < 5 => "Novice",
            < 10 => "Apprentice",
            < 15 => "Journeyman",
            < 20 => "Expert",
            _ => "Master"
        };
    }
}
public class MoodFactory
{
    public Mood CreateMood(int points)
    {
        string moodName = string.Empty;

        if (points < -5)
        {
            moodName = "Angry";
        }
        else if (points <= 0)
        {
            moodName = "Sad";
        }
        else if (points <= 15)
        {
            moodName = "Happy";
        }
        else
        {
            moodName = "JavaScript";
        }

        return new Mood(moodName);
    }
}

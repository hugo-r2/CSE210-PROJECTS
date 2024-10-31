public class LevelManager
{
    private int _level;
    private int _pointsRequired;

    public LevelManager()
    {
        _level = 1; 
        _pointsRequired = 500; 
    }

    public int Level => _level;

    public void CheckLevelUp(int score)
    {
        while (score >= _level * _pointsRequired)
        {
            _level++;
        }
    }
}

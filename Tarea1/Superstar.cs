namespace Tarea1;

public class Superstar
{
    private string _name { get; }
    private int _handSize { get; }
    private int _starValue { get; }
    private string _superStarAbility { get; }

    public Superstar(string name, int HandSize, int StarValue, string SuperStarAbility)
    {
        _name = name;
        _handSize = HandSize;
        _starValue = StarValue;
        _superStarAbility = SuperStarAbility;
    }
    public string GetName () // Getter
        {
            return _name;
        }
    
    
    
}

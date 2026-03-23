namespace OBP200_RolePlayingGame;

public abstract class Room
{
    public string Label { get;  }

    protected Room(string label)
    {
        Label = label;
    }

    public abstract bool Enter();
}
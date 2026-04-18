namespace OBP200_RolePlayingGame;

public class RestRoom : Room
{
    public RestRoom(string label) : base(label)
    {
    }

    public override bool Enter()
    {
        return Program.DoRest(); 
    }
}
namespace OBP200_RolePlayingGame;

public class BattleRoom : Room
{
    private bool isBoss;
    public BattleRoom(string label, bool isBoss = false) : base(label)
    {
        this.isBoss = isBoss;
    }

    public override bool Enter()
    {
        return Program.DoBattle(isBoss); 
    }
}

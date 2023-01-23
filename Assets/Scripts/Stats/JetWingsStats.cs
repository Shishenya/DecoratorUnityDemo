public class JetWingsStats : StatsDecorator
{

    public JetWingsStats(IStatsProvider wrappedEntity): base(wrappedEntity)
    {
    }

    protected override CharacterStats GetStatsInternal()
    {
        return _wrappedEntity.GetStats() * 2;
    }
}

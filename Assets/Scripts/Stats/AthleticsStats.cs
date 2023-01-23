public class AthleticsStats : StatsDecorator
{

    private readonly AthleticsType _athleticsType;

    public AthleticsStats(IStatsProvider wrappedEntity, AthleticsType athleticsType): base(wrappedEntity)
    {
        _athleticsType = athleticsType;
    }

    protected override CharacterStats GetStatsInternal()
    {
        return _wrappedEntity.GetStats() + GetAthleticsStats(_athleticsType);
    }

    private CharacterStats GetAthleticsStats(AthleticsType athleticsType)
    {
        switch (athleticsType)
        {
            case AthleticsType.run:
                return new CharacterStats()
                {
                    speed = 5,
                    jumpForce = 0
                };
            case AthleticsType.jump:
                return new CharacterStats()
                {
                    speed = 0,
                    jumpForce = 5,
                };
            default:
                return new CharacterStats()
                {
                    speed = 0,
                    jumpForce = 0,
                };
        }
    }

}

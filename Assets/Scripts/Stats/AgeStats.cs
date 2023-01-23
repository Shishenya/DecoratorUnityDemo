public class AgeStats : IStatsProvider
{
    private readonly AgeType _ageType;

    public AgeStats (AgeType ageType)
    {
        _ageType = ageType;
    }

    public CharacterStats GetStats()
    {
        switch (_ageType)
        {
            case AgeType.young:
                return new CharacterStats()
                {
                    speed = 10,
                    jumpForce = 5,
                };
            case AgeType.average:
                return new CharacterStats()
                {
                    speed = 12,
                    jumpForce = 7,
                };
            case AgeType.old:
                return new CharacterStats()
                {
                    speed = 8,
                    jumpForce = 4,
                };
            default:
                return new CharacterStats()
                {
                    speed = 1,
                    jumpForce = 1,
                };
        }
    }
}

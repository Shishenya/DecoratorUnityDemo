public class Player
{
    private AgeType _ageType;
    private AthleticsType _athleticsType;

    private IStatsProvider _provider;
    public IStatsProvider StatsProvider { get => _provider; }

    public Player(AgeType ageType, AthleticsType athleticsType)
    {
        _ageType = ageType;
        _athleticsType = athleticsType;

        InitStats();
    }

    public void InitStats()
    {
        // ������ �������
        _provider = new AgeStats(_ageType);

        // ������ ��� ��������
        _provider = new AthleticsStats(_provider, _athleticsType);

    }
}

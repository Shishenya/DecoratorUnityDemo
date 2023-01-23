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
        // задаем возраст
        _provider = new AgeStats(_ageType);

        // задаем тип атлетики
        _provider = new AthleticsStats(_provider, _athleticsType);

    }
}

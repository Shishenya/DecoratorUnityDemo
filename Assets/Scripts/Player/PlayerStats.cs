using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private Player _player;
    [SerializeField] private AgeType _ageType = AgeType.average;
    [SerializeField] private AthleticsType _athleticsType = AthleticsType.run;

    private void Awake()
    {
        _player = new Player(_ageType, _athleticsType);
        Debug.Log("��������: " + _player.StatsProvider.GetStats().speed);
        Debug.Log("���� ������: " + _player.StatsProvider.GetStats().jumpForce);
    }

    public CharacterStats GetStats()
    {
        return _player.StatsProvider.GetStats();
    }
}

using System.Collections.Generic;
using UnityEngine;

public class WallsInstantiate : MonoBehaviour
{
    [SerializeField] private PlayerMove _playerMove;

    [SerializeField] private float _yStartPositionMax = 6.5f;
    [SerializeField] private float _yStartPositionMin = -6.5f;

    [SerializeField] private GameObject _wallPrefab = null;
    [SerializeField] private float _widthPrefab = 25f;

    private int _currentIndexInstantiate = 0;
    private int _startWallAmount = 5;
    private List<GameObject> _downWalls = new List<GameObject>();
    private List<GameObject> _upperWalls = new List<GameObject>();

    [SerializeField] private Transform _parentWalls = null;

    private void Awake()
    {
        for (int i = 0; i < _startWallAmount; i++)
        {
            InstantiateNewWall(i * _widthPrefab);
            _currentIndexInstantiate = i;
        }
    }

    private void Update()
    {
        if (_playerMove.transform.position.x > _downWalls[0].transform.position.x + _widthPrefab)
        {
            RemoveWalls();
            _currentIndexInstantiate++;
            InstantiateNewWall(_currentIndexInstantiate * _widthPrefab);
        }
    }

    private void InstantiateNewWall(float xPosition)
    {
        GameObject upperWall = Instantiate(_wallPrefab, _parentWalls);
        GameObject downWall = Instantiate(_wallPrefab, _parentWalls);

        _upperWalls.Add(upperWall);
        _downWalls.Add(downWall);

        upperWall.transform.position = new Vector2(xPosition, _yStartPositionMax);
        downWall.transform.position = new Vector2(xPosition, _yStartPositionMin);
    }

    private void RemoveWalls()
    {
        Destroy(_upperWalls[0]);
        Destroy(_downWalls[0]);
        _upperWalls.RemoveAt(0);
        _downWalls.RemoveAt(0);
    }
}

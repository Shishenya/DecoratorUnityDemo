using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private PlayerStats _playerStats;
    private float _speed;
    private float _jumpForce;
    [SerializeField] private float _multiplier = 0.05f;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerStats = GetComponent<PlayerStats>();
    }

    private void Start()
    {
        InitStats();
    }

    private void InitStats()
    {
        _speed = _playerStats.GetStats().speed;
        _jumpForce = _playerStats.GetStats().jumpForce;
    }

    private void Update()
    {
        float y = Input.GetAxis("Vertical");
        if (y > 0)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        MoveForce();
    }

    private void MoveForce()
    {
        _rigidbody2D.AddForce(Vector2.right * _speed * _multiplier);
    }

    private void Jump()
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpForce * _multiplier);
    }
}

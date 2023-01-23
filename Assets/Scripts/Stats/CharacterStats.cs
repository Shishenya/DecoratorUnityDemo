public struct CharacterStats
{
    public float speed { get; set;  }
    public float jumpForce { get; set;  }

    public static CharacterStats operator +(CharacterStats a, CharacterStats b)
    {
        return new CharacterStats()
        {
            speed = a.speed + b.speed,
            jumpForce = a.jumpForce + b.jumpForce,
        };
    }


    public static CharacterStats operator *(CharacterStats a, float m)
    {
        return new CharacterStats()
        {
            speed = a.speed * m,
            jumpForce = a.jumpForce * m,
        };
    }

}

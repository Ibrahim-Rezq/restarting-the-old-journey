using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private float Horizontal, Vertical;
    [SerializeField] private float Speed = 5;
    [SerializeField] private int Health = 3;
    [SerializeField] private bool IsPlayerAlive=true;
    Rigidbody2D Rb2d;
    HealthSystemUi HealthSystemUi;
    void Awake()
    {
        Rb2d = gameObject.GetComponent<Rigidbody2D>();
        HealthSystemUi = HealthSystemUi.Instance;
    }

    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        Rb2d.velocity = new Vector2(Horizontal, Vertical) * Speed;
        if (!IsPlayerAlive)
        {
            // Show Dead Screen
            print("Player is Dead");
        }
    }
    public void SetDamage(int DamageNumber = 1)
    {
        Health -= DamageNumber;
        HealthSystemUi.UpdateHearts(Health);
        if (Health <= 0)
        {
            IsPlayerAlive = false;
        }
    }
    
}

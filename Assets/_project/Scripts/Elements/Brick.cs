using DG.Tweening;
using System;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public float punchPower;

    public int startHealth;
    private int _currentHealth;

    public SpriteRenderer sprite;

    private void Start()
    {
        _currentHealth = startHealth;

    }

    public void GetHit(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}

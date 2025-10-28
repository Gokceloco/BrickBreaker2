using DG.Tweening;
using System;
using TMPro;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public float punchPower;

    public int startHealth;
    private int _currentHealth;

    public SpriteRenderer sprite;
    public SpriteRenderer spriteNoGlow;
    public SpriteRenderer hitEffectSprite;
    public TextMeshPro healthText;

    public float punchScale;

    private void Start()
    {
        _currentHealth = startHealth;
        healthText.text = _currentHealth.ToString();
        sprite.DOFade(0, .5f).SetLoops(-1, LoopType.Yoyo);
    }

    public void GetHit(int damage)
    {
        _currentHealth -= damage;
        healthText.text = _currentHealth.ToString();
        
        sprite.transform.DOScale(.25f, .1f).SetLoops(2, LoopType.Yoyo);
        spriteNoGlow.transform.DOScale(.25f, .1f).SetLoops(2, LoopType.Yoyo);
        healthText.DOColor(Color.red, .1f).SetLoops(2, LoopType.Yoyo);
        healthText.transform.DOPunchPosition(Vector3.one * punchScale, .2f, 30);

        if (_currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        sprite.DOKill();
        sprite.transform.DOKill();
        spriteNoGlow.transform.DOKill();
        healthText.DOKill();
        healthText.transform.DOKill();
    }
}

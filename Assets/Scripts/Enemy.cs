using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;
    [HideInInspector]
    public float speed;


    public float startHealth = 100;
    private float health;

    public int gold = 10;
    public GameObject deathEffect;

    [Header("Unity Stuff")]
    public Image healthBar;

    void Start()
    {
        speed = startSpeed;
        health = startHealth; 
    }


    public void TakeDamage(float amount)
    {
        
        health -= amount;
        healthBar.fillAmount = health / startHealth;
        
        if(health <= 0)
        {
            Die();
        }
    }

    public void Slow (float pct)
    {
        speed = startSpeed * (1f - pct);
    }

    void Die ()
    {
        PlayerStats.Money += gold;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 3f);

        Destroy(gameObject);
    }

    
}

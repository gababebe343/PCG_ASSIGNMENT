using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        DamageDealer damageDealer = other.GetComponent<DamageDealer>();

        if (damageDealer != null)
        {
            TakeDamage(damageDealer.damage);
            Destroy(other.gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
            Destroy(gameObject);
    }
}

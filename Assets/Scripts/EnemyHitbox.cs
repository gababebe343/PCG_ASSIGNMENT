using UnityEngine;

public class EnemyHitbox : MonoBehaviour
{
    EnemyHealth health;

    void Awake()
    {
        health = GetComponent<EnemyHealth>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("PlayerBullet"))
            return;

        DamageDealer damage = other.GetComponent<DamageDealer>();
        if (damage == null)
            return;

        health.TakeDamage(damage.damage);
        Destroy(other.gameObject);
    }
}

using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 1.5f;

    float nextFireTime;
    DamageDealer damageDealer;

    void Start()
    {
        damageDealer = GetComponent<DamageDealer>();
    }

    void Update()
    {
        if (bulletPrefab == null || damageDealer == null)
            return;

        if (Time.time >= nextFireTime)
        {
            GameObject bullet = Instantiate(
                bulletPrefab,
                transform.position,
                Quaternion.Euler(0, 0, 180)
            );

            DamageDealer bulletDamage = bullet.GetComponent<DamageDealer>();
            if (bulletDamage != null)
                bulletDamage.damage = damageDealer.damage;

            nextFireTime = Time.time + fireRate;
        }
    }
}

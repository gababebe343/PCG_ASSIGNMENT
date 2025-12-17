using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("EnemyBullet"))
            return;

        DamageDealer damage = other.GetComponent<DamageDealer>();
        if (damage == null)
            return;

        health -= damage.damage;
        Destroy(other.gameObject);

        if (health <= 0)
            SceneManager.LoadScene("GameOver");
    }
}

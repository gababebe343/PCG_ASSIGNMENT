using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        DamageDealer damageDealer = other.GetComponent<DamageDealer>();

        if (damageDealer != null)
        {
            health -= damageDealer.damage;
            Destroy(other.gameObject);

            if (health <= 0)
                SceneManager.LoadScene("GameOver");
        }
    }
}

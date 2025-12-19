using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public GameObject explosionPrefab;
    bool isDead;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (isDead || GameManager.instance == null)
            return;

        DamageDealer damageDealer = other.GetComponent<DamageDealer>();
        if (damageDealer == null)
            return;

        GetComponent<AudioSource>().Play();

        GameManager.instance.DamagePlayer(damageDealer.damage);
        Destroy(other.gameObject);

        if (GameManager.instance.playerHealth <= 0)
        {
            isDead = true;

            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            StartCoroutine(GameOverDelay());
        }
    }

    IEnumerator GameOverDelay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("GameOver");
    }
}

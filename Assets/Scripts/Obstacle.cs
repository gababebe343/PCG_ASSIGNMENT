using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject explosionPrefab;
    AudioSource audioSource;
    bool destroyed;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (destroyed)
            return;

        if (other.CompareTag("Player"))
        {
            destroyed = true;

            if (explosionPrefab != null)
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            if (audioSource != null)
                audioSource.Play();

            Destroy(gameObject, 0.1f);
        }
    }
}

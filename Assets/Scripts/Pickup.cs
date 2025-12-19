using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float speed = 2f;
    public int scoreValue = 1;

    AudioSource audioSource;
    bool collected;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -Camera.main.orthographicSize - 2f)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (collected || GameManager.instance == null)
            return;

        if (other.CompareTag("Player"))
        {
            collected = true;
            GameManager.instance.AddScore(scoreValue);

            if (audioSource != null)
                audioSource.Play();

            Destroy(gameObject, 0.1f);
        }
    }
}

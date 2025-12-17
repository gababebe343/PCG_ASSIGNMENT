using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float speed = 2f;
    public int scoreValue = 1;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -Camera.main.orthographicSize - 2f)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Pickup hit: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected");
            GameManager.instance.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }

}

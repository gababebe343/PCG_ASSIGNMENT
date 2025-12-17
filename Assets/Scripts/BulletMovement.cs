using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y > Camera.main.orthographicSize + 2f)
            Destroy(gameObject);
    }
}

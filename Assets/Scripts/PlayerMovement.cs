using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    float minX;
    float maxX;

    void Start()
    {
        float camHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;
        minX = -camHalfWidth;
        maxX = camHalfWidth;
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += input * speed * Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        transform.position = pos;
    }
}

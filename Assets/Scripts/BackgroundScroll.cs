using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speed = 0.5f;
    Material mat;
    Vector2 offset;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offset.y += speed * Time.deltaTime;
        mat.mainTextureOffset = offset;
    }
}

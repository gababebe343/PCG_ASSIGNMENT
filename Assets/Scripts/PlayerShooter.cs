using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 0.3f;

    float nextFireTime;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;

            GetComponent<AudioSource>().Play();
        }
    }
}

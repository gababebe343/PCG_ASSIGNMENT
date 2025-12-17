using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform path;
    public float speed = 2f;

    int waypointIndex;
    Transform[] waypoints;

    void Start()
    {
        waypoints = path.GetComponentsInChildren<Transform>();
        transform.position = waypoints[1].position;
        waypointIndex = 1;
    }

    void Update()
    {
        if (waypointIndex >= waypoints.Length)
        {
            Destroy(gameObject);
            return;
        }

        Transform target = waypoints[waypointIndex];
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        if (transform.position == target.position)
            waypointIndex++;
    }
}

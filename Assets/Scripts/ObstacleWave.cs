using UnityEngine;

[CreateAssetMenu(menuName = "Waves/Obstacle Wave")]
public class ObstacleWave : ScriptableObject
{
    public GameObject enemyPrefab;
    public Transform pathPrefab;
    public float speed;
    public int count;
}

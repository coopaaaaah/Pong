using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Rigidbody2D ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnBall(0, 0);
    }
    
    public void SpawnBall(int x, int y)
    {
        // Calculate world position based on grid coordinates and cell size
        Vector2 spawnPosition = new Vector2(x, y);
        Instantiate(ball, spawnPosition, Quaternion.identity);
    }
}

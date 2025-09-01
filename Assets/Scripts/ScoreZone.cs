using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private GameLogic _gameLogic;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        _gameLogic.ScorePoint(ball, name);
    }
}

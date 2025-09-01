using TMPro;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public BallSpawner ballSpawner;
    public TextMeshProUGUI playerOneScore;
    public TextMeshProUGUI playerTwoScore;
    public void ScorePoint(Ball ball, string scoreZoneName)
    {
        
        if (scoreZoneName == "Player 1 Score Zone")
        {
            playerOneScore.text = (int.Parse(playerOneScore.text) + 1).ToString();
        }
        else
        {
            playerTwoScore.text = (int.Parse(playerTwoScore.text) + 1).ToString();
        }
        
        Destroy(ball);
        ballSpawner.SpawnBall(0,0);
    }
}
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        int deltaScore;

        switch (gameObject.tag)
        {
            case "chicken":
                deltaScore = 10;
                break;
            case "cow":
                deltaScore = 1;
                break;
            case "fox":
                deltaScore = 5;
                break;
            default:
                deltaScore = 0;
                break;
        }

        if(deltaScore > 0)
        {
            scoreManager.updateScore(deltaScore);
        }

        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

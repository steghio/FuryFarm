using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private ScoreManager scoreManager;

    [SerializeField] private float speed = 40f;
    [SerializeField] private float bound;

    private void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(bound > 0 && transform.position.z > bound)
        {
            Destroy(gameObject);
        }

        if(bound < 0 && transform.position.z < bound)
        {
            scoreManager.gameOver();
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}

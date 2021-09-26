using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private AudioSource _audioSource;

    private int score;
    private int highscore;

    [SerializeField] private AudioClip hitClip;
    [SerializeField] private AudioClip gameOverClip;

    [SerializeField] private TextMesh scoreText;
    [SerializeField] private TextMesh highscoreText;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        score = 0;
        highscore = PlayerPrefs.GetInt("highscore", 0);
        highscoreText.text = highscore.ToString();
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void updateScore(int val)
    {
        score += val;
        _audioSource.PlayOneShot(hitClip);
    }

    public void gameOver()
    {
        _audioSource.PlayOneShot(gameOverClip);
        PlayerPrefs.SetInt("highscore", score);
    }
}

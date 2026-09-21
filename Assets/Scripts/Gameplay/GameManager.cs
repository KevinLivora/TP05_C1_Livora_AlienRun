using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("References")]
    [SerializeField] private GameplayHud hud;

    [Header("World Speed")]
    [SerializeField] private float initialSpeed = 7f;
    [SerializeField] private float maxSpeed = 16f;
    [SerializeField] private float acceleration = 0.1f;

    private const string BestScoreKey = "BestScore";

    private float score;
    private int lastShownScore = -1;

    public bool IsPlaying { get; private set; }
    public float WorldSpeed { get; private set; }

    private void Awake()
    {
        Instance = this;
        IsPlaying = true;
        WorldSpeed = initialSpeed;
    }

    private void Update()
    {
        if (!IsPlaying)
            return;

        WorldSpeed = Mathf.Min(WorldSpeed + acceleration * Time.deltaTime, maxSpeed);
        score += WorldSpeed * Time.deltaTime;

        int currentScore = Mathf.FloorToInt(score);
        if (currentScore == lastShownScore)
            return;

        lastShownScore = currentScore;
        hud.SetScore(currentScore);
    }

    public void EndGame()
    {
        if (!IsPlaying)
            return;

        IsPlaying = false;

        int finalScore = Mathf.FloorToInt(score);
        int bestScore = Mathf.Max(PlayerPrefs.GetInt(BestScoreKey, 0), finalScore);
        PlayerPrefs.SetInt(BestScoreKey, bestScore);
        PlayerPrefs.Save();

        hud.ShowGameOver(finalScore, bestScore);
    }
}

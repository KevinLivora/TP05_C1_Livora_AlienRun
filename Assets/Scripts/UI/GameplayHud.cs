using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayHud : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] private TMP_Text scoreText;

    [Header("Game Over")]
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TMP_Text finalScoreText;
    [SerializeField] private TMP_Text bestScoreText;
    [SerializeField] private Button btnRetry;
    [SerializeField] private Button btnMenu;

    private const string MainMenuScene = "Main Menu";

    private void Awake()
    {
        btnRetry.onClick.AddListener(OnRetryClicked);
        btnMenu.onClick.AddListener(OnMenuClicked);

        gameOverPanel.SetActive(false);
    }

    private void OnDestroy()
    {
        btnRetry.onClick.RemoveAllListeners();
        btnMenu.onClick.RemoveAllListeners();
    }

    public void SetScore(int score)
    {
        scoreText.text = $"Score: {score}";
    }

    public void ShowGameOver(int finalScore, int bestScore)
    {
        finalScoreText.text = $"Score: {finalScore}";
        bestScoreText.text = $"Best: {bestScore}";
        gameOverPanel.SetActive(true);
    }

    private void OnRetryClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnMenuClicked()
    {
        SceneManager.LoadScene(MainMenuScene);
    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private Canvas gameOverPanel;
    [SerializeField] private TextMeshProUGUI finalScoreText;
    [SerializeField] private Button restartButton;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
        if (gameOverPanel != null)
        {
            gameOverPanel.gameObject.SetActive(false);
        }

        if (restartButton != null)
        {
            restartButton.onClick.AddListener(() => gameManager.RestartGame());
        }
    }

    public void UpdateScore(int score)
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void UpdateHighScore(int highScore)
    {
        if (highScoreText != null)
        {
            highScoreText.text = "High Score: " + highScore;
        }
    }

    public void ShowGameOverPanel()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.gameObject.SetActive(true);
            
            if (finalScoreText != null && gameManager != null)
            {
                finalScoreText.text = "Final Score: " + gameManager.GetScore();
            }
        }
    }
}

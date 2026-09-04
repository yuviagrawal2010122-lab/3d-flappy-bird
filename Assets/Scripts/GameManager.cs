using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private int highScore = 0;
    
    private PipeSpawner pipeSpawner;
    private UIManager uiManager;
    private bool isGameOver = false;

    private void Start()
    {
        pipeSpawner = FindObjectOfType<PipeSpawner>();
        uiManager = FindObjectOfType<UIManager>();
        
        // Load high score from PlayerPrefs
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        
        if (uiManager != null)
        {
            uiManager.UpdateScore(score);
            uiManager.UpdateHighScore(highScore);
        }
    }

    public void AddScore(int points)
    {
        if (!isGameOver)
        {
            score += points;
            
            if (score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("HighScore", highScore);
                PlayerPrefs.Save();
            }

            if (uiManager != null)
            {
                uiManager.UpdateScore(score);
                uiManager.UpdateHighScore(highScore);
            }
        }
    }

    public void GameOver()
    {
        isGameOver = true;

        if (pipeSpawner != null)
        {
            pipeSpawner.StopSpawning();
        }

        if (uiManager != null)
        {
            uiManager.ShowGameOverPanel();
        }

        Time.timeScale = 0f; // Pause game
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public int GetScore() => score;
    public int GetHighScore() => highScore;
    public bool IsGameOver() => isGameOver;
}

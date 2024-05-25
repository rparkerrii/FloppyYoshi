using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    // This will display increased score in the console on unity
    [ContextMenu("Increased Score")]

    // This function will add the score to player score and also display the current score on the screen
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    // This function will restart the game
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // This function calls the game over screen to appear
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    // Reference to the pause menu panel UI
    public GameObject pauseMenuPanel;
    
    // Track if game is paused
    private bool isPaused = false;

    void Update()
    {
        // Check if player presses Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    // Function to pause the game
    public void PauseGame()
    {
        Debug.Log("Game Paused");
        pauseMenuPanel.SetActive(true);  // Show pause menu
        Time.timeScale = 0f;             // Freeze game time
        isPaused = true;
    }

    // Function to resume the game
    public void ResumeGame()
    {
        Debug.Log("Game Resumed");
        pauseMenuPanel.SetActive(false); // Hide pause menu
        Time.timeScale = 1f;             // Resume game time
        isPaused = false;
    }

    // Function to restart current game
    public void RestartGame()
    {
        Debug.Log("Restarting Game");
        Time.timeScale = 1f;             // Make sure time is running
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Function to go back to main menu
    public void BackToMainMenu()
    {
        Debug.Log("Going to Main Menu");
        Time.timeScale = 1f;             // Make sure time is running
        SceneManager.LoadScene("MainMenu");
    }
}
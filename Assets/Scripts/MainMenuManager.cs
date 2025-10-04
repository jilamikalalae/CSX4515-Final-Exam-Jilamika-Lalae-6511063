using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // This function loads the Driving Game
    public void PlayDrivingGame()
    {
        Debug.Log("Loading Driving Game");
        SceneManager.LoadScene("DrivingGame");
    }

    // This function loads the Flying Game
    public void PlayFlyingGame()
    {
        Debug.Log("Loading Flying Game");
        SceneManager.LoadScene("FlyingGame");
    }

    // This function loads the Sumo Game
    public void PlaySumoGame()
    {
        Debug.Log("Loading Sumo Game");
        SceneManager.LoadScene("SumoGame");
    }

    // This function exits the game
    public void ExitGame()
    {
        Debug.Log("Exiting Game");
        
        // This works in the Unity Editor
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // This works in a built game
            Application.Quit();
        #endif
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("No more scenes available. End of game.");
            // You can implement other logic here, such as returning to the main menu
        }
    }

    
     public void PlayNewGame()
    {
       SceneManager.LoadScene(1); //returns next level
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the game
    }
        public void PauseGame()
    {
        Time.timeScale = 0f; // Set time scale to 0 to pause the game
        // You can also add other pause-related logic here
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Set time scale back to 1 to resume the game
        // You can also add other resume-related logic here
    }
    public void RestatCurrentScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void RestartLevelOne(){
        SceneManager.LoadScene("level1");
    }
    public void RestartLevelTwo(){
        SceneManager.LoadScene("level1");
    }
}



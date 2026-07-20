using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public string gameSceneName;

  
    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }

}

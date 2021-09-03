using UnityEngine;
using UnityEngine.SceneManagement;
using NaughtyAttributes;

public class SceneHandler : MonoBehaviour
{
    [Header("Parameter"), Scene]
    public int scene;

    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}

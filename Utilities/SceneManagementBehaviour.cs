using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Scene))]

public class SceneManagementBehaviour : MonoBehaviour
{
    public void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

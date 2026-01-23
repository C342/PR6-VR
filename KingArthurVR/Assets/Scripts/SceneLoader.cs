using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
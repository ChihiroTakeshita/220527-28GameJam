using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Result()
    {
        SceneManager.LoadScene("result");
    }

    public void Retry()
    {
        SceneManager.LoadScene("title");
    }
}

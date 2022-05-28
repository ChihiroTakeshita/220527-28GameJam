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
        SceneManager.LoadScene("Result");
    }

    //public void Retry()
    //{
    //    SceneManager.LoadScene("Shot");
    //}
}

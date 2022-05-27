using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Shot");
    }
}

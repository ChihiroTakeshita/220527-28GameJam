using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;
    [SerializeField]
    Text _text = default;

    float _score = default;
    // Start is called before the first frame update
    void Start()
    {
        _text.text = "スコア:" + 0;
    }
    // Update is called once per frame
    void Update()
    {
        _text.text = "スコア:" + _score;
    }

    public void UpdateScore(int score)
    {
        _score = score;
    }

    
}

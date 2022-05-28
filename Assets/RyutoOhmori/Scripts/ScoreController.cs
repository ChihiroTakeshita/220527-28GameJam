using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;
    [SerializeField]
    Text _text = default;

    [SerializeField]
    ParticleSystem particle;

    int _score = default;

    int _a = default; 
    // Start is called before the first frame update
    void Start()
    {
        _text.text = "スコア:" + 0;
    }
    // Update is called once per frame
    void Update()
    {
        _score = (int)GameManager.Score;

        _text.text = "スコア:" + _score;
        _score++;
        if (_a < _score)
        {
            ParticleSystem newParticle = Instantiate(particle);
            newParticle.transform.position = this.transform.position;
            newParticle.Play();
            Destroy(newParticle.gameObject, 5.0f);
        }

        _a = _score;
    }

    public void UpdateScore(int score)
    {
        _score = score;
    }
    
}

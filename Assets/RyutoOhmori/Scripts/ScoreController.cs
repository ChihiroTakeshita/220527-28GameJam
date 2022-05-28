using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;
    [SerializeField]
    Text _text = default;

    [SerializeField]
    ParticleSystem particle;

    [SerializeField] int _effectInterval = default;

    int _score = default;

    int a = 1;
    //int _a = default; 
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
        //_score++;
        if (_score > _effectInterval * a)
        {
            ParticleSystem newParticle = Instantiate(particle);
            newParticle.transform.position = this.transform.position;
            newParticle.Play();
            Destroy(newParticle.gameObject, 5.0f);
            a++;
        }

    }

    public void UpdateScore(int score)
    {
        _score = score;
    }
    
}

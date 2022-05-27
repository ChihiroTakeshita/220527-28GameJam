using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawner : MonoBehaviour
{
    [SerializeField] RainManager _rm;

    private float _posOffset = 1.5f;
    private float _judgeInterval;

    private void Awake()
    {
        _judgeInterval = _rm.JudgeInterval;
        _judgeInterval += Random.Range(0f, _rm.Frequency[0] - 1);
    }

    //private void Start()
    //{
    //    GenerateRain();
    //}

    private void Update()
    {
        _judgeInterval += Time.deltaTime;

        if(_judgeInterval > _rm.Frequency[_rm.Level])
        {
            GenerateRain();

            _judgeInterval = 0f;
        }
    }

    private void GenerateRain()
    {
        if (Random.Range(0f, 1f) > 0.5f)
        {
            Debug.Log("発生したよ");
            Instantiate(_rm.Rain, new Vector2(Random.Range(transform.position.x - _posOffset, transform.position.x + _posOffset), transform.position.y), Quaternion.identity);
        }
        else
        {
            Debug.Log("発生しなかったよ");
        }
    }
}

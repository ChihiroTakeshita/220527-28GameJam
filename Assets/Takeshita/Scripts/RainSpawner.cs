using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawner : MonoBehaviour
{
    [SerializeField, Tooltip("雨のプレハブ")] GameObject _rain;
    [SerializeField, Tooltip("1レベル上がるまでの時間(秒)")] float _levelUpTime;
    [SerializeField,Tooltip("レベルごとの雨発生判定をする頻度(秒)")] List<float> _frequency = new List<float>();

    private int _level;
    private float _offset = 1.5f;
    private float _judgeInterval;
    private float _lastLevelUp;

    private void Start()
    {
        GenerateRain();
    }

    private void Update()
    {
        _judgeInterval += Time.deltaTime;

        if(_judgeInterval > _frequency[_level])
        {
            GenerateRain();

            _judgeInterval = 0f;
        }

        if(Time.time - _lastLevelUp >= _levelUpTime)
        {
            LevelUp();
        }
    }

    private void GenerateRain()
    {
        if (Random.Range(0f, 1f) > 0.5f)
        {
            Debug.Log("発生したよ");
            Instantiate(_rain, new Vector2(Random.Range(transform.position.x - _offset, transform.position.x + _offset), transform.position.y), Quaternion.identity);
        }
        else
        {
            Debug.Log("発生しなかったよ");
        }
    }

    private void LevelUp()
    {
        Debug.Log("レベルアップしたよ");
        _level++;
    }
}

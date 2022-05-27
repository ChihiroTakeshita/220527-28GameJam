using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainManager : MonoBehaviour
{
    [SerializeField, Tooltip("雨のプレハブ")] GameObject _rain;
    [SerializeField, Tooltip("1レベル上がるまでの時間(秒)")] float _levelUpTime;
    [SerializeField, Tooltip("レベルごとの雨発生判定をする頻度(秒)")] List<float> _frequency = new List<float>();

    private int _level;
    private float _judgeInterval;
    private float _levelUpInterval;

    public GameObject Rain { get => _rain; private set => _rain = value; }
    public float LevelUpTime { get => _levelUpTime; private set => _levelUpTime = value; }
    public List<float> Frequency { get => _frequency; private set => _frequency = value; }
    public int Level { get => _level; private set => _level = value; }
    public float JudgeInterval { get => _judgeInterval; private set => _judgeInterval = value; }
    public float LevelUpInterval { get => _levelUpInterval;private set => _levelUpInterval = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelUpInterval += Time.deltaTime;

        if (LevelUpInterval >= LevelUpTime)
        {
            LevelUp();
            LevelUpInterval = 0;
        }
    }

    private void LevelUp()
    {
        if(_level < _frequency.Count - 1)
        {
            _level++;
            Debug.Log($"レベルアップしたよ 現在のレベル：{_level}");
        }
    }
}

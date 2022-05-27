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
    private float _lastLevelUp;

    public GameObject Rain { get => _rain; private set => _rain = value; }
    public float LevelUpTime { get => _levelUpTime; private set => _levelUpTime = value; }
    public List<float> Frequency { get => _frequency; private set => _frequency = value; }
    public int Level { get => _level; private set => _level = value; }
    public float JudgeInterval { get => _judgeInterval; private set => _judgeInterval = value; }
    public float LastLevelUp { get => _lastLevelUp;private set => _lastLevelUp = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - LastLevelUp >= LevelUpTime)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        Debug.Log("レベルアップしたよ");
        _level++;
    }
}

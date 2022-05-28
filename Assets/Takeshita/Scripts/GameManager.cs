using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _manager;

    private float _startTime;
    private float _resultTime;
    private static float _score;
    private static float _bonus = 1f;

    public float ResultTime { get => _resultTime; private set => _resultTime = value; }
    public static GameManager Instance { get => _manager; private set => _manager = value; }
    public static float Score { get => _score; private set => _score = value; }
    public static float Bonus { get => _bonus; set => _bonus = value; }

    private void Awake()
    {
        if(Instance)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    private void Update()
    {
        Score += Time.deltaTime * Bonus;
    }

    /// <summary>
    /// ゲーム開始時に呼ばれる関数
    /// </summary>
    public void StartGame()
    {
        _startTime = Time.time;
    }


    /// <summary>
    /// ゲーム終了時に呼ばれる関数
    /// </summary>
    public void FinishGame()
    {
        ResultTime = Time.time -_startTime;
    }
}

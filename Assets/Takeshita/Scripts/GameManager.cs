using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _manager;

    private float _startTime;
    private float _resultTime;

    public float ResultTime { get => _resultTime; private set => _resultTime = value; }
    public static GameManager Instance { get => _manager; private set => _manager = value; }

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
        ResultTime = _startTime - Time.time;
    }
}

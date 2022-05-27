using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _manager;

    private float _startTime;
    private float _resultTime;

    public float ResultTime { get => _resultTime; private set => _resultTime = value; }

    private void Awake()
    {
        if(_manager)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _manager = this;
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

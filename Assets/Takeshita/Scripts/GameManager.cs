using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float _startTime;
    private float _resultTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        _resultTime = _startTime - Time.time;
    }
}

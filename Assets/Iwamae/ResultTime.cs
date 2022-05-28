using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTime : MonoBehaviour
{
    [Tooltip("生存時間を表示するテキスト")]
    [SerializeField] Text _timeText;

    void Start()
    {
        _timeText.text = "Time :" + GameObject.FindGameObjectWithTag("GameManager").
            GetComponent<GameManager>().ResultTime.ToString("F2") + "秒";

    }
}

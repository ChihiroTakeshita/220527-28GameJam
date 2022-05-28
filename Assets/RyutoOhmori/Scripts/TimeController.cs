//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeController : MonoBehaviour
{
    [SerializeField]
    Text _text = default;

    float _timer = default;

    bool _isStop = default;

    void Update()
    {
        _timer += Time.deltaTime;
        _text.text = "タイム:" + _timer.ToString("f1");
    }
}

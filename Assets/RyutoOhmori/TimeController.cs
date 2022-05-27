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
        if (_isStop) { return; }

        _timer += Time.deltaTime;
        _text.text = _timer.ToString("f1");
    }

    public void ControlTime()
    {
        _isStop ^= true;
    }
}

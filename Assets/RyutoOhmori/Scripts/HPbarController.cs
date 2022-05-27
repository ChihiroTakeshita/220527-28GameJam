using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbarController : MonoBehaviour
{
    [SerializeField] int _maxHp = 5;
    int currentHp;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        currentHp = _maxHp;
    }

    private void Update()
    {
        slider.value = (float)currentHp / (float)_maxHp;
    }

    public void UpdateHp(int hp)
    {
        currentHp = hp;
    }
}

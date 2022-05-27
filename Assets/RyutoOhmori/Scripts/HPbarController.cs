using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbarController : MonoBehaviour
{
    [SerializeField] int _maxHp = 5;
    [SerializeField] Image _image;
    int currentHp;
    [SerializeField] Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1f;
        currentHp = _maxHp;
    }

    private void Update()
    {
        //slider.value = (float)currentHp / (float)_maxHp;
        if (slider.value < 0.5f)
        {
            _image.color = Color.yellow;
        }

        if (slider.value < 0.25f)
        {
            _image.color = Color.red;
        }
    }

    public void UpdateHp(int hp)
    {
        currentHp = hp;
    }
}

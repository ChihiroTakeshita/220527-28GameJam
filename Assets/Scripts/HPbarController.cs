using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbarController : MonoBehaviour
{
    [SerializeField] float _maxHp = 5;
    [SerializeField] Image _image;
    float currentHp;
    //int pastHp;
    [SerializeField] Slider slider;
    //int Time = default;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        currentHp = _maxHp;
    }

    private void Update()
    {
        /*if (slider.value > currentHp / _maxHp)
        {
            _image.color = Color.red;
            Time = 0;
        }
        if (Time == 30)
        {
            _image.color = Color.green;
        }*/


        slider.value = currentHp / _maxHp;
        /*if (Time % 200 == 0)
        {
            currentHp -= 1;
        }*/
        if (slider.value < 0.5f)
        {
            _image.color = Color.yellow;
        }

        if (slider.value < 0.25f)
        {
            _image.color = Color.red;
        }
        //pastHp = currentHp
        
    }

    public void UpdateHp(int hp)
    {
        currentHp = hp;
    }
}

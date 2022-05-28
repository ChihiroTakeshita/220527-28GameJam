using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInController : MonoBehaviour
{
    void Start()
    {
        GetComponent<Image>().enabled = true;
    }

    void Update()
    {

    }

    // フェードイン終了後の処理
    public void EndFadeInAnimation()
    {
        Destroy(this.gameObject);
    }
}
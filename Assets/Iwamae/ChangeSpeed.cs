using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 取得すると移動速度が変わるアイテム
/// </summary>
[RequireComponent(typeof(BoxCollider2D))]
public class ChangeSpeed : ItemBase
{
    [Tooltip("アイテムを取ったら設定されるスピード")]
    [SerializeField] float _setSpeed = 10f;
    [Tooltip("アイテムの効果時間")]
    [SerializeField] float _duration = 1.0f;

    float _saveSpeed = 5.0f;
    PlayerController _player;
    SpriteRenderer _sprite;

    public override void Activate()
    {
        Debug.Log("Active");
        _sprite = GetComponent<SpriteRenderer>();
        //画像を非表示にする
        _sprite.enabled = false;
        var playerObj = GameObject.FindGameObjectWithTag("Player");

        if(playerObj)
        {
            _player = playerObj.GetComponent<PlayerController>();
            if(_player)
            {
                Debug.Log("SetSpeed");
                _saveSpeed = _player.DefaultSpeed;
                _player.SetSpeed = _setSpeed;
                StartCoroutine(DurationItem());
            }
        }
    }

    IEnumerator DurationItem() 
    {
        yield return new WaitForSeconds(_duration);
        _player.SetSpeed = _saveSpeed;
        Destroy();
    }
}

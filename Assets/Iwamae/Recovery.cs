using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 取得したら回復するアイテム
/// </summary>
[RequireComponent(typeof(BoxCollider2D))]
public class Recovery : ItemBase
{
    [Tooltip("アイテムを取ったら回復するHP量")]
    [SerializeField] int _recoveryHp = 1;

    PlayerController _player;
    SpriteRenderer _sprite;

    public override void Activate()
    {
        Debug.Log("Active");
        _sprite = GetComponent<SpriteRenderer>();
        //画像を非表示にする
        _sprite.enabled = false;
        var playerObj = GameObject.FindGameObjectWithTag("Player");

        if (playerObj)
        {
            _player = playerObj.GetComponent<PlayerController>();
            if (_player)
            {
                Debug.Log("回復した");

                if (_player.HP == _player.HpMax)
                {
                    
                    return;
                }
                _player.HP += _recoveryHp;
            }
        }
    }
}

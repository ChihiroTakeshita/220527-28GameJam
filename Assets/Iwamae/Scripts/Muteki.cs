using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 取得したら一定時間無敵になるアイテム
/// </summary>
[RequireComponent (typeof(BoxCollider2D))]
public class Muteki : ItemBase
{
    [Tooltip("アイテムの効果時間")]
    [SerializeField] float _duration = 1.0f;
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
                Debug.Log("無敵中");
                _player.IsMuteki = true;
                StartCoroutine(DurationItem());
            }
        }
    }

    IEnumerator DurationItem()
    {
        yield return new WaitForSeconds(_duration);
        _player.IsMuteki = false;
        Debug.Log("無敵終了");
        Destroy();
    }
}

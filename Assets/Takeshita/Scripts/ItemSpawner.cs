using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField, Tooltip("アイテムのプレハブ")] List<GameObject> _items = new List<GameObject>();
    [SerializeField, Tooltip("アイテム発生判定の頻度(秒)")] float _frequency;
    [SerializeField, Tooltip("アイテム発生地帯の右端")] Transform _rightEnd;
    [SerializeField, Tooltip("アイテム発生地帯の左端")] Transform _leftEnd;

    private float _interval;

    private void Update()
    {
        _interval += Time.deltaTime;

        if( _interval > _frequency )
        {
            GenerateItem();
            _interval = 0;
        }
    }

    private void GenerateItem()
    {
        if (Random.Range(0f, 1f) > 0.5f)
        {
            Debug.Log("アイテムが発生したよ");
            Instantiate(_items[Random.Range(0, _items.Count - 1)], new Vector2(Random.Range(_leftEnd.position.x, _rightEnd.position.x), transform.position.y), Quaternion.identity);
        }
        else
        {
            Debug.Log("アイテムは発生しなかったよ");
        }
    }
}

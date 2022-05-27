using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Tooltip("プレイヤーの移動速度")]
    [SerializeField] float _speed = 5.0f;
    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(h, 0);
        _rb.velocity = dir.normalized * _speed;
    }
}

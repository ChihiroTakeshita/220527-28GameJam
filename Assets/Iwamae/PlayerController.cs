using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent ((typeof (Rigidbody2D)), (typeof(CircleCollider2D)))]
public class PlayerController : MonoBehaviour
{
    [Tooltip("プレイヤーの移動速度")]
    [SerializeField] float _speed = 5.0f;
    [Tooltip("プレイヤーの体力")]
    [SerializeField] int _hp = 3;
    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(_hp < 1)
        {
            SceneManager.LoadScene("GameOver");
        }

        float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(h, 0);
        _rb.velocity = dir.normalized * _speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Rain")
        {
            _hp--;
        }
    }
}

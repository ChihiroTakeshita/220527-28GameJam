using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent ((typeof (Rigidbody2D)), (typeof(CircleCollider2D)))]
public class PlayerController : MonoBehaviour
{
    [Tooltip("プレイヤーの移動速度")]
    [SerializeField] float _speed = 5.0f;
    public float Speed => _speed;
    [Tooltip("プレイヤーの体力")]
    [SerializeField] int _hp = 3;
    [Tooltip("体力ゲージ")]
    [SerializeField]Slider _hpGage;
    Rigidbody2D _rb;

    public float SetSpped
    {
        set
        {
            _speed = value;
        }
    }

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

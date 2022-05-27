using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent((typeof(Rigidbody2D)), (typeof(CircleCollider2D)))]
public class PlayerController : MonoBehaviour
{
    [Tooltip("プレイヤーの移動速度")]
    [SerializeField] float _speed = 5.0f;
    public float Speed => _speed;
    [Tooltip("プレイヤーの体力")]
    [SerializeField] int _hp = 3;
    
    public int HpMax { get; private set; }
    public float DefaultSpeed { get; private set; }
    public bool IsMuteki { get; set; } = false;
    public int HP { get { return _hp; } set { _hp = value; } }
    public float SetSpped
    {
        set
        {
            _speed = value;
        }
    }

    Rigidbody2D _rb;

    void Start()
    {
        HpMax = _hp;
        DefaultSpeed = _speed;
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
        if(IsMuteki)
        {
            return;
        }

        if (collision.gameObject.tag == "Rain")
        {
            _hp--;
        }
    }
}

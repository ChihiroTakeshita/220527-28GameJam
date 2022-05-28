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
    public float SetSpeed
    {
        set
        {
            _speed = value;
        }
    }

    bool _isRight = false;

    Animator _anim;
    Rigidbody2D _rb;
    SpriteRenderer _sprite;

    void Start()
    {
        HpMax = _hp;
        DefaultSpeed = _speed;
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(_hp < 1)
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().FinishGame();
            SceneManager.LoadScene("Result");
        }

        float h = Input.GetAxisRaw("Horizontal");
        Vector2 dir = new Vector2(h, 0);
        _rb.velocity = dir.normalized * _speed;
        _anim.SetFloat("Speed", _rb.velocity.magnitude);

        Vector3 scale = transform.localScale;
        if (h > 0 && !_isRight)
        {
            _isRight = true;
            // 右方向に移動中
            scale.x *= -1; //（右向き）
        }
        else if(h < 0 && _isRight)
        {
            _isRight = false;
            // 左方向に移動中
            scale.x *= -1; // 反転する（左向き）
        }
        // 代入し直す
        transform.localScale = scale;
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

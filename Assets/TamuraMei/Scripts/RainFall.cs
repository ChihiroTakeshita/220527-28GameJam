using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainFall : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float speed = 0;
    [SerializeField] SpriteRenderer spriteRenderer;
    //[SerializeField] Sprite hitRain;
    [SerializeField] CircleCollider2D col;


    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(3, 6);
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector2(-0.6f, -1.0f) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10 || transform.position.x < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Field")
        {
            col.enabled = false;

            spriteRenderer.color = Color.blue;
            //spriteRenderer.sprite = hitRain;

            _rb.velocity = new Vector2(-0.1f, 0.2f) * speed;
            Destroy(gameObject, 0.3f);

            /*Instantiate(HitRain, transform.position, Quaternion.identity);
            Destroy(HitRain, 0.2f); ←これでエラー出た　
            から、spriteRendererを変更してDestroyする形に変更　*/
        }
    }
}

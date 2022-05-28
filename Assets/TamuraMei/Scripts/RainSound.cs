using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSound : MonoBehaviour
{
    private AudioSource _audio;
    [SerializeField] AudioClip hitPlayer;

    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            _audio.pitch += 0.5f;
            _audio.PlayOneShot(hitPlayer);
        }
    }
}

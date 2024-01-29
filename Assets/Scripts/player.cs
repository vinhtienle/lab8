using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    public AudioClip jumd;
    public AudioClip colle;
    private AudioSource audioSource;
    public GameObject tao;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = rb.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float nhay = 2;
    public void jum()
    {
        rb.AddForce(Vector2.up * nhay, ForceMode2D.Impulse);
    }
    public void moveleft()
    {
      
        rb.AddForce(Vector2.left * nhay, ForceMode2D.Impulse);
    }
    public void moveRight()
    {
        rb.AddForce(Vector2.right * nhay, ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "tao")
        {
            audioSource.PlayOneShot(colle);
            Destroy(collision.gameObject);
        }
    }

}

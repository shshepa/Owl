using UnityEngine;
using System.Collections;

public class HeroLevel1 : MonoBehaviour {

    public float hp = 3f;
    public float damage = 0.6f;

    private RootLevel1 root;
    private Animator animHero;
    private Animator animCamera;
    private Animator animBack;
    private Rigidbody2D rb;
    private Progres progres;
    private PlayerMove move;
    public void TakeDamage(float damage)
    {
        hp = hp - damage;
        if (hp == 0f)
        {
            Death();
        }
    }
    public void Won()
    {
        move.enabled = false;
        root.enabled = false;
        this.transform.Translate(0.05f, 0f, 0f);
        this.gameObject.layer = 9;
        animBack.enabled = false;
    }
    private void Start()
    {
        move = GetComponent<PlayerMove>();
        root = GameObject.Find("Main Camera").GetComponent<RootLevel1>();
        progres = GameObject.Find("progres").GetComponent<Progres>();
        animHero = GameObject.Find("hero").GetComponent<Animator>();
        animCamera = GameObject.Find("Main Camera").GetComponent<Animator>();
        animBack = GameObject.Find("zadnik").GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D stolk)
    {
        if(stolk.gameObject.tag == "Enemy")
        {
            animCamera.Play("shake");
            TakeDamage(damage);
        }
    }

    
    private void Death()
    {
        move.enabled = false;
        root.enabled = false;
        progres.enabled = false;
        animHero.enabled = false;
        animBack.enabled = false;
        this.gameObject.layer = 9;
        rb.AddForce(new Vector2(0f, 1500f));
        rb.gravityScale = 1;
    }
}

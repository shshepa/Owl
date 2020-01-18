using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBrokenPart : MonoBehaviour
{
    private float timer = 3f;
    private float speed = 0.005f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(Random.insideUnitSphere * 200);
    }
    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        this.transform.localScale = new Vector3(this.transform.localScale.x - speed, this. transform.localScale.y - speed, 0f);
        if (timer <= 0f)
            TimerOff();
    }
    private void TimerOff()
    {
        Destroy(this.gameObject);
    }
}

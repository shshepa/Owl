using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float forse;

    private Rigidbody2D _rb;
    private GameObject _prefab;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _prefab = Resources.Load<GameObject>("Prefabs\\level1\\fireball");
    }

    private void FixedUpdate() {
        Move();
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }  
    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _prefab.transform.position = new Vector3(this.transform.position.x + 0.9f, this.transform.position.y, this.transform.position.z);
            Instantiate(_prefab);
        }
        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(new Vector2(0f, forse));
        }
        if(Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(new Vector2(0f, -forse));
        }
        if(Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(new Vector2(-forse, 0f));
        }
        if(Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(new Vector2(forse, 0f));
        }
       
    }
}

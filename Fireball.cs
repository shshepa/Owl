using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {
    public float speed;

	private void FixedUpdate() {
        this.transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);

	}
    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.name == "GranicaRight")
        {
            Destroy(this.gameObject);
        }

    }
}

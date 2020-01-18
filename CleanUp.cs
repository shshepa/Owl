using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUp : MonoBehaviour
{
    void FixedUpdate()
    {
        if (transform.childCount == 0)
            Destroy(this.gameObject);
    }
}

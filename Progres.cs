using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progres : MonoBehaviour
{
    private HeroLevel1 hero;

    private void Start()
    {
        hero = GameObject.Find("hero").GetComponent<HeroLevel1>();
    }
    void FixedUpdate()
    {
        if (this.transform.localPosition.x >= 0.32f)
        {
            hero.Won();
        }
        else
        {
            transform.Translate(0.005f, 0f, 0f);
        }
    }
}

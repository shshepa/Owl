using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHealth : MonoBehaviour {
    private HeroLevel1 hero;
	void Start () {

        hero = GameObject.Find("hero").GetComponent<HeroLevel1>();
	}
	void FixedUpdate() {
        this.transform.localScale = new Vector3(hero.hp, 0.2f, 1f);
	}
}

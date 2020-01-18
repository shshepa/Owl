using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float speed;
    public float speedRotation;


    private Timer timer;
    private GameObject _prefabNewBochka;
    private GameObject _prefabNewFish;
    private GameObject _prefabNewStone;
    private Vector3 pos;
    private Transform tr;
    
    private void Start () {
        tr = GetComponent<Transform>();
        _prefabNewBochka = Resources.Load<GameObject>("Prefabs\\level1\\bochkaBroke");
        _prefabNewStone = Resources.Load<GameObject>("Prefabs\\level1\\StoneBroke");
        _prefabNewFish = Resources.Load<GameObject>("Prefabs\\level1\\FishBroke");
        timer = GetComponent<Timer>();
	}

    private void FixedUpdate () {
        this.transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        this.transform.Rotate(0f, 0f , speedRotation);
        if(timer.enabled == false)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D (Collision2D stolk)
    {
        if (stolk.gameObject.tag == "Fire")
        {
            EnemyReplace(this.gameObject.name);
            Destroy(stolk.gameObject);
        }

    }
    private void EnemyReplace(string name)
    {
        switch(name)
        {
            case "BochkaEnemy":
                pos = this.transform.position;
                Destroy(this.gameObject);
                _prefabNewBochka.transform.position = tr.position;
                _prefabNewBochka.transform.rotation = tr.rotation;
                Instantiate(_prefabNewBochka);
                break;
            case "FishEnemy":
                pos = this.transform.position;
                Destroy(this.gameObject);
                _prefabNewFish.transform.position = tr.position;
                _prefabNewFish.transform.rotation = tr.rotation;
                Instantiate(_prefabNewFish);
                break;
            case "StoneEnemy":
                pos = this.transform.position;
                Destroy(this.gameObject);
                _prefabNewStone.transform.position = pos;
                Instantiate(_prefabNewStone);
                break;
        }
    }

}

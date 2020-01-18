using UnityEngine;
using System.Collections;

public class RootLevel1 : MonoBehaviour {

    public float firstSpawn;
    public float subtractionTime;
    public float maxSpawn;

    private float timeToRespawn;
    private GameObject clone;
    private GameObject _prefabBochka;
    private GameObject _prefabFish;
    private GameObject _prefabStone;
    private int numEnemy;
    private Timer _timer;
    private void Start()
    {
        timeToRespawn = firstSpawn;
        _prefabBochka = Resources.Load<GameObject>("Prefabs\\level1\\BochkaEnemy");
        _prefabStone = Resources.Load<GameObject>("Prefabs\\level1\\StoneEnemy");
        _prefabFish = Resources.Load<GameObject>("Prefabs\\level1\\FishEnemy");
        _timer = GetComponent<Timer>();
    }
    private void FixedUpdate() => CreateEnemy();
    
    private void CreateEnemy()
    {
        if (_timer.enabled == false)
        {
            numEnemy = Random.Range(1, 4);
            switch (numEnemy)
            {
                case 1:
                    _prefabBochka.transform.position = new Vector3(10f, Random.Range(-3f, 3f), 0f);
                    clone = Instantiate(_prefabBochka);
                    clone.name = "BochkaEnemy";
                    TimerSpawn(timeToRespawn);
                    break;
                case 2:
                    _prefabStone.transform.position = new Vector3(10f, Random.Range(-3f, 3f), 0f);
                    clone = Instantiate(_prefabStone);
                    clone.name = "StoneEnemy";
                    TimerSpawn(timeToRespawn);
                    break;
                case 3:
                    _prefabFish.transform.position = new Vector3(10f, Random.Range(-3f, 3f), 0f);
                    clone = Instantiate(_prefabFish);
                    clone.name = "FishEnemy";
                    TimerSpawn(timeToRespawn);
                    break;
            }
        }
    }
    private void TimerSpawn(float timer)
    {
        if( (timeToRespawn - subtractionTime) >= maxSpawn)
        {
            timeToRespawn -= subtractionTime;
            _timer.timer = timeToRespawn;
            _timer.enabled = true;
        }
        else
        {
            timeToRespawn = maxSpawn;
            _timer.timer = timeToRespawn;
            _timer.enabled = true;
        }
        
    }
}
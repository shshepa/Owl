using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public float timer;
    public float timeLvl = 0;
    private float workTime;
    private void Start()
    {
        workTime = timer;
    }
    void FixedUpdate()
    {
        timeLvl += Time.deltaTime;
        workTime -= Time.deltaTime;
        if (workTime <= 0f)
            TimerOff();
    }
    private void TimerOff()
    {
        this.enabled = false;
        workTime = timer;
    }

}
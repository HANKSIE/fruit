using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandle : MonoBehaviour
{
    public Text Countdown;
    public Text PlayTime;
    public float Second = 3f;
    private float sec;
    public float PlaySecond = 5f;

    void Start(){
        sec = Second + 1;
        PlayTime.text = ((int)PlaySecond).ToString();
        StartPrepareCountDown();
    }

    void Update()
    {
    }

    void Prepare()
    {
        if(sec > 0){
            if(sec < Second + 1){
                Countdown.text = ((int)sec).ToString();
            }
            sec -= 1;
            return;
        }

        Countdown.enabled  = false;
        StartPlayCountDown();
        CancelInvoke("Prepare");
    }

    void StartPrepareCountDown()
    {
        InvokeRepeating("Prepare", 0, 1);
    }

    void StartPlayCountDown(){
        InvokeRepeating("PlayCountDown", 1, 1);
    }

    void PlayCountDown(){
        if(PlaySecond > 0){
            PlaySecond -= 1;
            PlayTime.text = ((int)PlaySecond).ToString();
            return;
        }
        CancelInvoke("PlayCountDown");
    }

    void GameStart(){
        Debug.Log("game start");
    }
}

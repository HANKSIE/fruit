using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text TextUI;
    public float Second = 3f;
    private float realSec; 
    private float sec;
    private bool hasRun = false;

    void Start(){
        realSec = Second + 1;
        sec = Second + 2;
    }

    void Update()
    {
        if(sec >= 0){
            if(sec < realSec){
                TextUI.text = ((int)sec).ToString();
            }
            sec -= Time.deltaTime;
        }else if(!hasRun){
            Debug.Log("game start!");
            hasRun = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalUpdate : MonoBehaviour{
    [Header("最後分數Text UI")]
    public Text Score;

    public void start(){
        GameHandle manager = GameObject.Find("GameManager").GetComponent<GameHandle>();
        Debug.Log(manager.score);
        Score.text = ((int)manager.score).ToString();
        Debug.Log(Score.text);
        Debug.Log(manager.score);
    }

}

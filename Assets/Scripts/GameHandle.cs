using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandle : MonoBehaviour
{
    [Header("準備時的倒數文字Text UI")]
    public Text PrepareCountdown;
    [Header("剩餘遊戲時間Text UI")]
    public Text PlayTime;
    [Header("倒數秒數")]
    public float Second = 3f;
    [Header("遊戲時間")]
    public float PlaySecond = 5f;
    [Header("分數")]
    public int score = 0;


    public GameObject[] Fruits;
    public FinalUpdate finUpdate; 

    private float sec; //準備時的倒數秒數

    void Start(){
        Debug.Log("Screen Width : " + Screen.width);
        sec = Second + 1; //多加一秒，為了讓提示字串顯示一秒避免直接顯示倒數數字
        PlayTime.text = ((int)PlaySecond).ToString();
        StartPrepareCountDown();
    }

    /// <summary>
    /// "準備"倒數
    /// </summary>
    void Prepare()
    {
        if(sec >= 0){
            //多加一秒，為了讓提示字串顯示一秒避免直接顯示倒數數字
            if(sec < Second + 1){
                //將顯示文字設定為秒數
                PrepareCountdown.text = ((int)sec).ToString();
            }
            sec -= 1;
            return;
        }

        PrepareCountdown.enabled  = false; //隱藏"準備"倒數UI
        StartPlayCountDown(); 
        CancelInvoke("Prepare"); //取消Prepare function調用
    }

    /// <summary>
    /// 調用"準備"倒數
    /// </summary>
    void StartPrepareCountDown()
    {
        InvokeRepeating("Prepare", 0, 1);//調用Prepare function
    }

    /// <summary>
    /// 調用遊戲時間倒數
    /// </summary>
    void StartPlayCountDown(){
        InvokeRepeating("PlayCountDown", 1, 1);//調用PlayCountDown function
    }

    /// <summary>
    /// 遊戲時間倒數
    /// </summary>
    void PlayCountDown(){
        if(PlaySecond > 0){
            Camera camera = GameObject.Find("Main Camera").GetComponent<Camera>();
            Debug.Log(camera.pixelWidth);
            PlaySecond -= 1;
            PlayTime.text = ((int)PlaySecond).ToString();
            Instantiate(Fruits[Random.Range(0,Fruits.Length-1)],new Vector3(Random.Range(1,27),13,0), Quaternion.identity);
            return;
        }else{
            DontDestroyOnLoad(GameObject.Find("GameManager"));
            SceneManager.LoadScene(2);
        }

        CancelInvoke("PlayCountDown"); //取消PlayCountDown function調用
    }

    public void plus(){
        score+=10;
    }


}
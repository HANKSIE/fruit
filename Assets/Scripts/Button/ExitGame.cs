using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void ClickHandle()
    {
        #if UNITY_EDITOR
            //unity編輯器環境
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            //實體運行環境
            Application.Quit();
        #endif
    }
}

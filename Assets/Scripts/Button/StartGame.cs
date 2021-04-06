using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void ClickHandle()
    {
        //切換到場景，場景id在 file > build settting 的 Scenes In Build 查看
        SceneManager.LoadScene(1);
    }
}

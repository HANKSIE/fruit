using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
   public void ClickHandle()
    {
        SceneManager.LoadScene(0);
        Destroy(GameObject.Find("GameManager"));
    }
}

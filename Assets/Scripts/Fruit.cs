using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class Fruit : MonoBehaviour
{
    // void Update()
    // {
    //     RaycastHit hit = new RaycastHit();
    //     Debug.Log();
    //     for (int i = 0; i < Input.touchCount; i++) {
    //         Ray ray = GameObject.Find("Main Camera").GetComponent<Camera>().ScreenPointToRay(Input.GetTouch(i).position);
    //         if (Input.GetTouch(i).phase.Equals(TouchPhase.Began)) {
    //             if (Physics.Raycast(ray, out hit)) {
    //                 DestroyMe();
    //             }
    //        }
    //    }
    // }

    void DestroyMe(){
        Destroy(gameObject);
        GameObject.Find("GameManager").GetComponent<GameHandle>().plus();
    }

    void OnMouseDown() {
        DestroyMe();
    }
}

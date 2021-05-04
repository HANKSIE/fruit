using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class Fruit : MonoBehaviour
{
    void OnMouseDown() {
        Destroy(gameObject);
        GameObject.Find("GameManager").GetComponent<GameHandle>().plus();
    }
}

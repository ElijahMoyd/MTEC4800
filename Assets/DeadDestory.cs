using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadDestory : MonoBehaviour
{
void OnCollisionEnter2D(Collision2D other) {
    if (other.gameObject.CompareTag("Enemy")) {
        Destroy(other.gameObject);
    }
}
}

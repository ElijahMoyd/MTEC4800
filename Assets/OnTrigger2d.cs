using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger2D: MonoBehaviour
{
void OnCollisionEnter2D(Collision2D other) {
    if (other.gameObject.CompareTag("Player")) {
        Destroy(GameObject.FindWithTag("Destroyable"));
    }
}
}
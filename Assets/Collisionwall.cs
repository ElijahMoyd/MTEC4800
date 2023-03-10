using UnityEngine;

public class Collisionwall : MonoBehaviour
{
    // This function will be called when a collision is detected
   void OnCollisionEnter2D(Collision2D other) {
    if (other.gameObject.CompareTag("Destroyable")) {
        Destroy(other.gameObject);
    }
}
}

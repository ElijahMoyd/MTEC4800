using UnityEngine;

public class Collisionwall : MonoBehaviour
{
    // This function will be called when a collision is detected
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected!");

        // You can access information about the collision here
        Debug.Log("Colliding with: " + collision.gameObject.name);
        Debug.Log("Relative velocity: " + collision.relativeVelocity);
    }
}

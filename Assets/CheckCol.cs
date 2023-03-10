using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCol : MonoBehaviour
{
 public int collisionCount = 0;
public int maxCollisions = 3;

void OnCollisionEnter2D(Collision2D col)
{
    // Check if the collision occurred with a specific game object
    if (col.gameObject.CompareTag("Enemy"))
    {
        // Increment the collision counter
        collisionCount++;

        // Check if the maximum number of collisions has been reached
        if (collisionCount >= maxCollisions)
        {
            // Call a function to activate some behavior
            Destroy(GameObject.FindWithTag("Destroyable"));
        }
    }
}
}

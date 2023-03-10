using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public int requiredCollisions = 1; // number of collisions required to destroy the game object

    private int currentCollisions = 0; // current number of collisions

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collidable")) // check if the colliding game object is a collidable object
        {
            currentCollisions++; // increment the collision count

            if (currentCollisions >= requiredCollisions) // check if the required number of collisions has been reached
            {
                Destroy(gameObject); // destroy the game object
            }
        }
    }
}
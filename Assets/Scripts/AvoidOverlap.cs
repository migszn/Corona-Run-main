using UnityEngine;

public class AvoidOverlap : MonoBehaviour
{
    [SerializeField] private float collisionRadius = 0.25f; // Adjust the radius as needed

    private void Start()
    {
        // Check for collisions on start
        CheckCollisions();
    }

    private void Update()
    {
        // You can add more dynamic checks here if needed
    }

    private void CheckCollisions()
    {
        // Check for collisions with other objects
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, collisionRadius);

        // If there are any colliders (other than itself), reposition the object
        if (colliders.Length > 1)
        {
            Reposition();
        }
    }

    private void Reposition()
    {
        // Randomize a new position
        Vector3 newPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f); // Adjust the range as needed

        // Set the new position
        transform.position = newPosition;

        // Check collisions again after repositioning
        CheckCollisions();
    }
}

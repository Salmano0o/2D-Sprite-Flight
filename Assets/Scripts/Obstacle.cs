using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float minSize = 0.5f;
    public float maxSize = 2.0f;

    public float minSpeed = 50f;
    public float maxSpeed = 150f;

    Rigidbody2D rb;

    void Start()
    {
        // 1. Randomize and apply local scale
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);

        // 2. Calculate random speed and direction
        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        Vector2 randomDirection = Random.insideUnitCircle;

        // 3. Get Rigidbody2D component reference and apply physical force
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(randomDirection * randomSpeed);
    }
}